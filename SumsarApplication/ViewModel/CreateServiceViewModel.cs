using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SumsarApplication.Model;
using SumsarApplication.Handler;
using SumsarApplication.Helpers;


namespace SumsarApplication.ViewModel
{
    class CreateServiceViewModel : INotifyPropertyChanged
    {
        //fields
        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        
        private int _identity;

        public int Identity
        {
            get { return _identity; }
            set { _identity = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _objectiveName;

        public string ObjectiveName
        {
            get { return _objectiveName; }
            set { _objectiveName = value; }
        }

        private string _objectiveDescription;

        public string ObjectiveDescription
        {
            get { return _objectiveDescription; }
            set { _objectiveDescription = value; }
        }


        private ObservableCollection<ServiceObjective> _objectiveCatalog;

        public ObservableCollection<ServiceObjective> ObjectiveCatalog
        {
            get { return _objectiveCatalog; }
            set { _objectiveCatalog = value; }
        }

        private ServiceHandler _handler;

        public ServiceHandler Handler
        {
            get { return _handler; }
            set { _handler = value; }
        }

        private ICommand _createServiceCommand;

        public ICommand CreateServiceCommand
        {
            get { return _createServiceCommand ?? (_createServiceCommand = new RelayCommand(Handler.CreateService)); }
            set { _createServiceCommand = value; }
        }

        private ICommand _createServiceObjectiveCommand;

        public ICommand CreateServiceObjectiveCommand
        {
            get { return _createServiceObjectiveCommand ?? (_createServiceObjectiveCommand = new RelayCommand(Handler.CreateServiceObjective)); }
            set { _createServiceObjectiveCommand = value; }
        }


        //ctor & overrides
        public CreateServiceViewModel()
        {
            Handler = new ServiceHandler(this);
            ObjectiveCatalog = new ObservableCollection<ServiceObjective>();
        }
        
        //methods
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
