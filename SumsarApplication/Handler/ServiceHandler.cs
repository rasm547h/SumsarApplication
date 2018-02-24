using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumsarApplication.ViewModel;
using SumsarApplication.Model;

namespace SumsarApplication.Handler
{
    class ServiceHandler
    {
        private ServiceOverviewViewModel _serviceOverviewViewModel;

        public ServiceOverviewViewModel ServiceOverviewViewModel
        {
            get { return _serviceOverviewViewModel; }
            set { _serviceOverviewViewModel = value; }
        }

        private CreateServiceViewModel _createServiceViewModel;

        public CreateServiceViewModel CreateServiceViewModel
        {
            get { return _createServiceViewModel; }
            set { _createServiceViewModel = value; }
        }

        //ctor & overrides

        //refactor: maybe some inheritance so "abstract class" only has service logic and no application logic. Then derived class's constructor has same parameters and VM DI.
        public ServiceHandler(ServiceOverviewViewModel viewModel)
        {
            ServiceOverviewViewModel = viewModel;
        }

        public ServiceHandler(CreateServiceViewModel viewModel)
        {
            CreateServiceViewModel = viewModel;
        }

        //methods
        public void CreateService()
        {
            //refactor: let singleton add new service, delivered by factory = high cohesion by take creational logic out of handler with dependecy on VM and low coupling by outsource creation to pattern.
            var newService = new Service(CreateServiceViewModel.Identity, CreateServiceViewModel.Description, CreateServiceViewModel.ObjectiveCatalog.ToList<ServiceObjective>());
            var temp = ServiceCatalogSingleton.Instance;
            temp.Services.Add(newService);
        }

        public void CreateServiceObjective()
        {
            var newServiceObjective = new ServiceObjective(CreateServiceViewModel.ObjectiveName, CreateServiceViewModel.ObjectiveDescription);
            CreateServiceViewModel.ObjectiveCatalog.Add(newServiceObjective);
        }
    }
}
