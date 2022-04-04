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
            regionManager.RegisterViewWithRegion("AllContentRegion", typeof(AllContentView));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(CarouselContainer));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<CarouselContainer>();
            containerRegistry.RegisterForNavigation<ContextMenuDemo>();
            containerRegistry.RegisterForNavigation<CoverFlowDemo>();
            containerRegistry.RegisterForNavigation<DataGridDemo>();
            containerRegistry.RegisterForNavigation<ExpanderMenu>();
            containerRegistry.RegisterForNavigation<MessageBoxDemo>();
            containerRegistry.RegisterForNavigation<MultiFunctionTabControl>();
            containerRegistry.RegisterForNavigation<NavigationPanel>();
            containerRegistry.RegisterForNavigation<NoticeDemo>();
            containerRegistry.RegisterForNavigation<SortGroup>();
            containerRegistry.RegisterForNavigation<TimeBarDemoView>();
            containerRegistry.RegisterForNavigation<TimeLine>();
            containerRegistry.RegisterForNavigation<TransitioningContentControlDemo>();
            containerRegistry.RegisterForNavigation<TreeMenu>();
            containerRegistry.RegisterForNavigation<UploadPic>();
        }
    }
}