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

namespace Fengsao.AuthorsModule.ViewModels;

public class AuthorsViewModel : BindableBase, INavigationAware
{
    private string? _poemTitle;
    public string? PoemTitle
    {
        get { return _poemTitle; }
        set { SetProperty(ref _poemTitle, value); }
    }
    private string? _poemAuthor;
    public string? PoemAuthor
    {
        get { return _poemAuthor; }
        set { SetProperty(ref _poemAuthor, value); }
    }
    private string? _poemText;
    public string? PoemText
    {
        get { return _poemText; }
        set { SetProperty(ref _poemText, value); }
    }

    public DelegateCommand NextCommand { get; private set; }

    private FengsaoService _fengsaoService;
    public AuthorsViewModel(FengsaoService fengsaoService)
    {
        _fengsaoService = fengsaoService;
        NextCommand = new DelegateCommand(Next);
    }
    private void Next()
    {
        var x = _fengsaoService.GetRandomTextual();
        PoemText = x.Text;
        PoemTitle = x.Title;
        PoemAuthor = $"{x.AuthorName}";
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
