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
    public DelegateCommand PreviousCommand { get; private set; }
    public DelegateCommand NextCommand { get; private set; }

    private FengsaoService _fengsaoService;
    public AuthorsViewModel(FengsaoService fengsaoService)
    {
        _fengsaoService = fengsaoService;
        Authors = new ObservableCollection<string>();
        PreviousCommand = new DelegateCommand(Previous).ObservesCanExecute(() => CanPrevious);
        NextCommand = new DelegateCommand(Next).ObservesCanExecute(() => CanNext);
        var authors = _fengsaoService.GetAuthor(_currentPage, _pageSize);
        foreach (var author in authors)
        {
            Authors.Add(author.Name);
        }
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
        var authors = _fengsaoService.GetAuthor(_currentPage, _pageSize);


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
        var authors = _fengsaoService.GetAuthor(_currentPage, _pageSize);

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
