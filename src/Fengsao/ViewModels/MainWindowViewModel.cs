using Fengsao.Application.Services;
using Fengsao.Views;
using Prism.Commands;
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
    private IRegion _randomRegion;

    public DelegateCommand LoadingCommand { get; set; }
    public DelegateCommand ShowAduskinCommand { get; set; }

    void ExecuteLoadingCommand()
    {
        //_regionMannager.RequestNavigate("RandomPoemRegion", "RandomPoem");
        //_regionMannager.RequestNavigate("PoemDynastyRegion", "Dynasty");
        //_regionMannager.RequestNavigate("EditRegion", "Dynasty");
    }
    void ShowAduskin()
    {
        var nextWindow = _containerProvider.Resolve<ShowAduSkin>();
        var currentWindow = System.Windows.Application.Current.MainWindow;
        System.Windows.Application.Current.MainWindow = nextWindow;
        nextWindow.Show();
        currentWindow.Close();
    }
    public MainWindowViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
    {
        ShowAduskinCommand = new DelegateCommand(ShowAduskin);
        LoadingCommand = new DelegateCommand(ExecuteLoadingCommand);
        _regionMannager = regionManager;
        _containerProvider = containerProvider;
        ResisterView();
    }
    void ResisterView()
    {
        var r = _regionMannager.Regions.ContainsRegionWithName("RandomPoemRegion");
        if (!r)
        {
            _regionMannager.RegisterViewWithRegion("RandomPoemRegion", "RandomPoem");
        }
         r = _regionMannager.Regions.ContainsRegionWithName("PoemDynastyRegion");
        if (!r)
        {
            _regionMannager.RegisterViewWithRegion("PoemDynastyRegion", "Dynasty");
        }
         r = _regionMannager.Regions.ContainsRegionWithName("EditRegion");
        if (!r)
        {
            _regionMannager.RegisterViewWithRegion("EditRegion", "Dynasty");
        }
        //_regionMannager.RequestNavigate("PoemDynastyRegion", "Dynasty");
        //_regionMannager.RequestNavigate("EditRegion", "Dynasty");
    }
}
