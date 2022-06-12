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

public class ShellViewModel : BindableBase
{
    private IRegionManager _regionManager;
    private IContainerProvider _containerProvider;
    
    public DelegateCommand LoadingCommand { get; set; }

    void ExecuteLoadingCommand()
    {
        //_regionMannager.RequestNavigate(FengsaoConst.RegionNameRandomPoem, "RandomPoem");
        //_regionMannager.RequestNavigate(FengsaoConst.RegionNamePoemDynasty, "Dynasty");
        //_regionMannager.RequestNavigate(FengsaoConst.RegionNameEdit, "Dynasty");
        var _region = _regionManager.Regions["ShellRegion"];
        var loginView = _containerProvider.Resolve<RandomPoem>();

        _region.Add(loginView);
    }
    
    public ShellViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
    {
        LoadingCommand = new DelegateCommand(ExecuteLoadingCommand);
        _regionManager = regionManager;
        _containerProvider = containerProvider;
    }
}
