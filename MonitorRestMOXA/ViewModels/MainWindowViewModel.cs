using MonitorRestMOXA.Core;
using MonitorRestMOXA.Core.Collection;
using MonitorRestMOXA.Core.Models;
using MonitorRestMOXA.Models;
using MonitorRestMOXA.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonitorRestMOXA.ViewModels
{
    public class MainWindowViewModel
        : BindableBase 
    {
        IMonitorRestMOXAContext _monitorRestMOXAContext;

        private void SetDIsStatus(DigitalInputCollection e)
        {
            DIContacts = new ObservableCollection<DIModel>(e.Select(t => new DIModel { DigitalInput = t }));
        }

        private void SetRlsStatus(RelayCollection e)
        {
            RelayContacts = new ObservableCollection<RelayModel>(e.Select(t => new RelayModel { Relay = t }));
        }

        string _addressMOXARestAPI = "http://127.0.0.1:5000/";
        public string AddressMOXARestAPI
        {
            get => _addressMOXARestAPI;
            set => SetProperty(ref _addressMOXARestAPI, value);
        }

        bool _dIReadOnlyIsChecked = false;
        public bool DIReadOnlyIsChecked
        {
            get => _dIReadOnlyIsChecked;
            set => SetProperty(ref _dIReadOnlyIsChecked, value);
        }

        bool _relayReadOnlyIsChecked = false;
        public bool RelayReadOnlyIsChecked
        {
            get => _relayReadOnlyIsChecked;
            set => SetProperty(ref _relayReadOnlyIsChecked, value);
        }

        IEnumerable<DIModel> _dIContacts;
        public IEnumerable<DIModel> DIContacts
        {
            get => _dIContacts;
            set => SetProperty(ref _dIContacts, value);
        }

        IEnumerable<RelayModel> _relayContacts;
        public IEnumerable<RelayModel> RelayContacts
        {
            get => _relayContacts;
            set => SetProperty(ref _relayContacts, value);
        }

        ICommand _refreshBoundCommand;
        public ICommand RefreshBoundCommand
                => _refreshBoundCommand ?? (_refreshBoundCommand = new RelayCommand(
                        _ =>
                        {
                            if (_monitorRestMOXAContext == null)
                                return;

                            SetDIsStatus(_monitorRestMOXAContext.DigitalInputCategory.Get());
                            SetRlsStatus(_monitorRestMOXAContext.RelayCategory.Get());

                        }));

        ICommand _createBoundCommand;
        public ICommand CreateBoundCommand
                => _createBoundCommand ?? (_createBoundCommand = new RelayCommand(
                        _ =>
                        {
                            _monitorRestMOXAContext = new MonitorRestMOXAContext(new MonitorRestMOXAContextStartupParams { Host = _addressMOXARestAPI, ModuleType = ModuleMXIOType.E1200 });
                            _monitorRestMOXAContext.DigitalInputCategory.OnChanged += (s,e) => SetDIsStatus(e);
                            _monitorRestMOXAContext.RelayCategory.OnChanged += (s, e) => SetRlsStatus(e);

                            RefreshBoundCommand.Execute(null);
                        }));

        ICommand _relayStatusChangedCommand;
        public ICommand RelayStatusChangedCommand
                => _relayStatusChangedCommand ?? (_relayStatusChangedCommand = new RelayCommand(
                        async _ =>
                        {
                            if(!RelayReadOnlyIsChecked)
                            {
                                await _monitorRestMOXAContext.RelayCategory.PutAsync(new RelayCollection(RelayContacts.Select(t => t.Relay).ToList()));
                            }     
                        }));

        ICommand _diStatusChangedCommand;
        public ICommand DIStatusChangedCommand
                => _diStatusChangedCommand ?? (_diStatusChangedCommand = new RelayCommand(
                        async _ =>
                        {
                            if (!DIReadOnlyIsChecked)
                            {
                                await _monitorRestMOXAContext.DigitalInputCategory.PutAsync(new DigitalInputCollection(DIContacts.Select(t => t.DigitalInput).ToList()));
                            }
                        }));
    }
}
