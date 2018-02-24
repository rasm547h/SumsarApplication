using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SumsarApplication.Handler;
using SumsarApplication.Helpers;
using SumsarApplication.Model;

namespace SumsarApplication.ViewModel
{
    class ServiceOverviewViewModel : INotifyPropertyChanged
    {
        
        private ServiceCatalogSingleton _serviceCatalogSingleton;

        public ServiceCatalogSingleton ServiceCatalogSingleton
        {
            get { return _serviceCatalogSingleton; }
            set { _serviceCatalogSingleton = value; }
        }

        private ServiceHandler _handler;

        public ServiceHandler Handler
        {
            get { return _handler; }
            set { _handler = value; }
        }
        
        //ctor & overrides
        public ServiceOverviewViewModel()
        {
            Handler = new ServiceHandler(this);
            ServiceCatalogSingleton = ServiceCatalogSingleton.Instance;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
