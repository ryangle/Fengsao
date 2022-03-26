using Fengsao.Application.Services;
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

    public IRegionManager RegionMannager { get; }

    private DelegateCommand? _loadingCommand;
    public DelegateCommand? LoadingCommand =>
        _loadingCommand ?? (_loadingCommand = new DelegateCommand(ExecuteLoadingCommand));

    void ExecuteLoadingCommand()
    {
        RegionMannager.RequestNavigate("RandomPoemRegion", "RandomPoem");
        RegionMannager.RequestNavigate("PoemDynastyRegion", "Dynasty");
    }
    public MainWindowViewModel(IRegionManager regionManager)
    {
        RegionMannager = regionManager;

    }
}
