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

public class RandomPoemViewModel : BindableBase, INavigationAware
{
    private string? _poemTitle;
    public string? PoemTitle
    {
        get { return _poemTitle; }
        set { SetProperty(ref _poemTitle, value); }
    }
    private string? _poemText;
    public string? PoemText
    {
        get { return _poemText; }
        set { SetProperty(ref _poemText, value); }
    }
    private FengsaoService _fengsaoService;
    public RandomPoemViewModel(FengsaoService fengsaoService)
    {
        _fengsaoService = fengsaoService;
        var x = _fengsaoService.GetRandomTextual();
        PoemText = x.Text;
        PoemTitle = x.Title;
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
