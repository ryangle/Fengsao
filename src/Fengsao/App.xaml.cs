using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using System.Windows;
using Prism.Regions;
using Fengsao.Application.Services;
using Fengsao.Views;

namespace Fengsao
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<FengsaoService>();
            containerRegistry.RegisterForNavigation<RandomPoem>();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            _ = moduleCatalog.AddModule<AuthorsModule.AuthorsModule>();
        }
    }

}
