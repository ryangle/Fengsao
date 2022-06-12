using Fengsao.Views;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;

namespace Fengsao.ViewModels;

public class AduSkinWindowViewModel : BindableBase
{
    private IRegionManager _regionMannager;
    private IContainerProvider _containerProvider;

    public DelegateCommand ShowFengsaoCommand { get; set; }
    void ShowFengsao()
    {
        var nextWindow = _containerProvider.Resolve<MainWindow>();
        var currentWindow = System.Windows.Application.Current.MainWindow;
        System.Windows.Application.Current.MainWindow = nextWindow;

        //if (currentWindow is FrameworkElement view && view.DataContext is null && ViewModelLocator.GetAutoWireViewModel(view) is null)
        //{
        //    ViewModelLocator.SetAutoWireViewModel(view, true);
        //}
        //RegionManager.SetRegionManager(currentWindow, _regionMannager);
        //RegionManager.UpdateRegions();

        nextWindow.Show();
        currentWindow.Hide();
    }
    public AduSkinWindowViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
    {
        ShowFengsaoCommand = new DelegateCommand(ShowFengsao);
        _regionMannager = regionManager;
        _containerProvider = containerProvider;
        //RegisterViewWithRegion();
    }
    void RegisterViewWithRegion()
    {
        var regions = _regionMannager.Regions;
        if (!regions.ContainsRegionWithName("AllContentRegion"))
        {
            _regionMannager.RegisterViewWithRegion("AllContentRegion", "AllContentView");
        }
        if (!regions.ContainsRegionWithName("OtherControlRegion"))
        {
            _regionMannager.RegisterViewWithRegion("OtherControlRegion", "CommonControl");
        }
       
    }
}
