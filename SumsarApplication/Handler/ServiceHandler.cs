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

        //ctor & overrides
        public ServiceHandler(ServiceOverviewViewModel viewModel)
        {
            ServiceOverviewViewModel = viewModel;
        }

        //methods
        public void CreateService()
        {
            var newService = new Service(ServiceOverviewViewModel.Identity, ServiceOverviewViewModel.Description, ServiceOverviewViewModel.ObjectiveCatalog.ToList<ServiceObjective>());
            ServiceOverviewViewModel.ServiceCatalogSingleton.Services.Add(newService);
        }
    }
}
