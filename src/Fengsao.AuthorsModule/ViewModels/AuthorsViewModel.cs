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

namespace Fengsao.AuthorsModule.ViewModels;

public class AuthorsViewModel : BindableBase
{
    private readonly IDialogService _dialogService;

    private ObservableCollection<string>? _authors;
    public ObservableCollection<string>? Authors
    {
        get { return _authors; }
        set { SetProperty(ref _authors, value); }
    }
    private int _currentPage = 0;
    public int _pageSize = 60;

    private bool _canNext = true;
    public bool CanNext
    {
        get { return _canNext; }
        set
        {
            SetProperty(ref _canNext, value);
            NextCommand.RaiseCanExecuteChanged();
        }
    }
    private bool _canPrevious = false;
    public bool CanPrevious
    {
        get { return _canPrevious; }
        set
        {
            SetProperty(ref _canPrevious, value);
            PreviousCommand.RaiseCanExecuteChanged();
        }
    }
    public DelegateCommand<string> ShowAuthorCommand { get; private set; }
    public DelegateCommand PreviousCommand { get; private set; }
    public DelegateCommand NextCommand { get; private set; }

    private FengsaoService _fengsaoService;
    public AuthorsViewModel(FengsaoService fengsaoService, IDialogService dialogService)
    {
        _fengsaoService = fengsaoService;
        _dialogService = dialogService;
        Authors = new ObservableCollection<string>();
        ShowAuthorCommand = new DelegateCommand<string>(ShowAuthor);
        PreviousCommand = new DelegateCommand(Previous).ObservesCanExecute(() => CanPrevious);
        NextCommand = new DelegateCommand(Next).ObservesCanExecute(() => CanNext);
        var authors = _fengsaoService.GetAuthors(_currentPage, _pageSize);
        foreach (var author in authors)
        {
            Authors.Add(author.Name);
        }
    }
    public void ShowAuthor(string authorName)
    {
        var p = new DialogParameters();
        p.Add("authorName", authorName);
        _dialogService.Show("AuthorView", p, r =>
        {
            if (r.Result == ButtonResult.OK)
            {
                r.Parameters.GetValue<string>("authorName");
            }
        });
    }
    public void Previous()
    {
        if (_currentPage == 0)
        {
            CanPrevious = false;
            return;
        }
        CanNext = true;

        _currentPage--;
        var authors = _fengsaoService.GetAuthors(_currentPage, _pageSize);


        if (Authors != null && authors != null)
        {
            Authors.Clear();
            foreach (var author in authors)
            {
                Authors.Add(author.Name);
            }
        }
    }
    public void Next()
    {
        _currentPage++;
        var authors = _fengsaoService.GetAuthors(_currentPage, _pageSize);

        if (authors != null && authors.Count > 0)
        {
            CanPrevious = true;
            if (authors.Count < _pageSize)
            {
                CanNext = false;
            }
        }
        else
        {
            CanNext = false;
        }

        if (Authors != null && authors != null)
        {
            Authors.Clear();
            foreach (var author in authors)
            {
                Authors.Add(author.Name);
            }
        }
    }
}
