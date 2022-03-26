using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using System.Windows;
using Prism.Regions;
using Fengsao.Application.Services;
using Fengsao.Views;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Unity;
using Unity.Microsoft.DependencyInjection;

namespace Fengsao
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Debug()
                .WriteTo.File("fengsao_.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<FengsaoService>();
            containerRegistry.RegisterForNavigation<RandomPoem>();
            containerRegistry.RegisterForNavigation<Dynasty>();
        }
        protected override IContainerExtension CreateContainerExtension()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

            var container = new UnityContainer();
            container.BuildServiceProvider(serviceCollection);
            return new UnityContainerExtension(container);
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            _ = moduleCatalog.AddModule<AuthorsModule.AuthorsModule>();
            _ = moduleCatalog.AddModule<AuthorsModule.AduSkinModule>();
        }
    }

}
