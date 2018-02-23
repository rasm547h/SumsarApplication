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
            var objs = new List<ServiceObjective>() { new ServiceObjective("Push biceps", "Use 16 lbs"), new ServiceObjective("Stretch out", "Remember breathing") };
            if (Services.Count == 0)
            {
                Services.Add(new Service(1, "Work out: Monday", objs));
                Services.Add(new Service(2, "Work out: Tuesday", objs));
                Services.Add(new Service(3, "Work out: Friday", objs));
            }
        }
        
        public void Add(Service service)
        {
            Services.Add(service);
        }
    }
}
