using Fengsao.AuthorsModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Fengsao.AuthorsModule
{
    public class AuthorsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("PoemAuthorRegion", typeof(Authors));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<AuthorView>("AuthorView");
        }
    }
}