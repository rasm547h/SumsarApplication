using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsarApplication.Model
{
    public class ServiceCatalogSingleton
    {
        private static ServiceCatalogSingleton _instance;

        public static ServiceCatalogSingleton Instance
        {
            get { return _instance ?? ( _instance = new ServiceCatalogSingleton()); }            
        }

        private ObservableCollection<Service> _services;

        public ObservableCollection<Service> Services
        {
            get { return _services; }
            set { _services = value; }
        }


        private ServiceCatalogSingleton()
        {
            Services = new ObservableCollection<Service>();
            if (Services.Count == 0)
            {
                Services.Add(new Service("1", "Work out"));
                Services.Add(new Service("2", "Call home"));
                Services.Add(new Service("3", "Go to doctor"));
            }
        }


        public void Add(Service service)
        {
            Services.Add(service);
        }
    }
}
