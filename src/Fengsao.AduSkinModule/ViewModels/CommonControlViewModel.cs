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

namespace Fengsao.AduSkinModule.ViewModels;

public class CommonControlViewModel : BindableBase
{
    //private Visibility _errorVisibility;
    //public Visibility ErrorVisibility
    //{
    //    get { return _errorVisibility; }
    //    set { SetProperty(ref _errorVisibility, value); }
    //}
    public CommonControlViewModel(FengsaoService fengsaoService)
    {
    }

}
