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
        //RegionMannager.RequestNavigate("PoemAuthorRegion", "RandomPoem");
        //RegionMannager.RequestNavigate("PoemDynastyRegion", "RandomPoem");
        //var x = _fengsaoService.GetRandomTextual();
        //PoemText = x.Text;
        //PoemTitle = x.Title;
    }
    private FengsaoService _fengsaoService;
    public MainWindowViewModel(IRegionManager regionManager,
        FengsaoService fengsaoService)
    {
        RegionMannager = regionManager;
        _fengsaoService = fengsaoService;

    }
}
