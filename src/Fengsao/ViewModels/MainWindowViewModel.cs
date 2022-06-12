using Fengsao.Application.Services;
using Fengsao.Resources;
using Fengsao.Views;
using Prism.Commands;
using Prism.Common;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Fengsao.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private IRegionManager _regionMannager;
    private IContainerProvider _containerProvider;
    private int _width;
    public int Width
    {
        get { return _width; }
        set { SetProperty(ref _width, value); }
    }
    public DelegateCommand LoadingCommand { get; set; }
    public DelegateCommand ShowAduskinCommand { get; set; }

    void ExecuteLoadingCommand()
    {
        //_regionMannager.RequestNavigate(FengsaoConst.RegionNameRandomPoem, "RandomPoem");
        //_regionMannager.RequestNavigate(FengsaoConst.RegionNamePoemDynasty, "Dynasty");
        //_regionMannager.RequestNavigate(FengsaoConst.RegionNameEdit, "Dynasty");
    }
    void ShowAduskin()
    {
        //var nextWindow = _containerProvider.Resolve<ShowAduSkin>();
        //var currentWindow = System.Windows.Application.Current.MainWindow;
        //System.Windows.Application.Current.MainWindow = nextWindow;

        ////MvvmHelpers.AutowireViewModel(currentWindow);
        ////if (nextWindow is FrameworkElement view && view.DataContext is null && ViewModelLocator.GetAutoWireViewModel(view) is null)
        ////{
        ////    ViewModelLocator.SetAutoWireViewModel(view, true);
        ////}
        ////var r = _regionMannager.Regions.ContainsRegionWithName(FengsaoConst.RegionNameOtherControl);
        ////if (!r)
        ////{
        ////    RegionManager.SetRegionManager(nextWindow, _regionMannager);
        ////}
        ////RegionManager.UpdateRegions();

        //nextWindow.Show();
        //currentWindow.Hide();
        Width = 1000;
    }
    public MainWindowViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
    {
        ShowAduskinCommand = new DelegateCommand(ShowAduskin);
        LoadingCommand = new DelegateCommand(ExecuteLoadingCommand);
        _regionMannager = regionManager;
        _containerProvider = containerProvider;
        RegisterViewWithRegion();
        Width = 500;
    }
    void RegisterViewWithRegion()
    {
        var regions = _regionMannager.Regions;
        if (!regions.ContainsRegionWithName(FengsaoConst.RegionNameRandomPoem))
        {
            _regionMannager.RegisterViewWithRegion(FengsaoConst.RegionNameRandomPoem, typeof(RandomPoem));
        }
        if (!regions.ContainsRegionWithName(FengsaoConst.RegionNamePoemDynasty))
        {
            _regionMannager.RegisterViewWithRegion(FengsaoConst.RegionNamePoemDynasty, typeof(Dynasty));
        }
        if (!regions.ContainsRegionWithName(FengsaoConst.RegionNameEdit))
        {
            _regionMannager.RegisterViewWithRegion(FengsaoConst.RegionNameEdit, typeof(Dynasty));
        }
    }
}
