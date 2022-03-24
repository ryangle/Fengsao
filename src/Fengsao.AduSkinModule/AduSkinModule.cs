using Fengsao.AduSkinModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Fengsao.AuthorsModule
{
    public class AduSkinModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("OtherControlRegion", typeof(CommonControl));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}