using Fengsao.Application.Models;
using Fengsao.Application.Services;
using Prism.Commands;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Fengsao.ViewModels;

public class DynastyViewModel : BindableBase, INavigationAware
{
    private ObservableCollection<DynastyDto>? _dynastys;
    public ObservableCollection<DynastyDto>? Dynastys
    {
        get { return _dynastys; }
        set { SetProperty(ref _dynastys, value); }
    }

    private FengsaoService _fengsaoService;
    public DynastyViewModel(FengsaoService fengsaoService)
    {
        _fengsaoService = fengsaoService;
        Dynastys = new ObservableCollection<DynastyDto>();
        var dys = _fengsaoService.GetDynastys();
        foreach (DynastyDto dynastyDto in dys)
        {
            Dynastys.Add(dynastyDto);
        }
    }
    public void OnNavigatedTo(NavigationContext navigationContext)
    {
        //throw new NotImplementedException();
        
    }

    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return true;
        //throw new NotImplementedException();
    }

    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
        //throw new NotImplementedException();
    }
}
