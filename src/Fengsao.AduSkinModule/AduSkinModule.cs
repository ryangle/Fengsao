using Fengsao.AduSkinModule.Views;
using Fengsao.Resources;
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
            regionManager.RegisterViewWithRegion(FengsaoConst.RegionNameOtherControl, typeof(CommonControl));
            regionManager.RegisterViewWithRegion(FengsaoConst.RegionNameAllContent, typeof(AllContentView));
            regionManager.RegisterViewWithRegion(FengsaoConst.RegionNameContent, typeof(TimeLine));

            //var contentRegion = regionManager.Regions["ContentRegion"];
            ////contentRegion.Add(ContainerLocator.Current.Resolve<CarouselContainer>());
            //contentRegion.Add(ContainerLocator.Current.Resolve<ContextMenuDemo>());
            //contentRegion.Add(ContainerLocator.Current.Resolve<TimeLine>());

            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(CarouselContainer));
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContextMenuDemo));
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(TimeLine));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CarouselContainer>();
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