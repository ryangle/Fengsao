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
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Fengsao.AuthorsModule.ViewModels;

public class AuthorViewModel : BindableBase, IDialogAware
{
    private string _authorName;
    public string Title => _authorName;
    private Author? _author;
    public Author? Author
    {
        get { return _author; }
        set { SetProperty(ref _author, value); }
    }
    private BitmapImage _imagesource;
    public BitmapImage Imagesource
    {
        get { return _imagesource; }
        set { SetProperty(ref _imagesource, value); }
    }

    private FengsaoService _fengsaoService;

    public event Action<IDialogResult> RequestClose;

    public AuthorViewModel(FengsaoService fengsaoService)
    {
        _fengsaoService = fengsaoService;
    }
    public bool CanCloseDialog()
    {
        return true;
    }

    public void OnDialogClosed()
    {
        if (RequestClose != null)
        {
            //RequestClose.Invoke();
        }
    }

    public void OnDialogOpened(IDialogParameters parameters)
    {
        _authorName = parameters.GetValue<string>("authorName");
        var author = _fengsaoService.GetAuthor(_authorName);
        if (string.IsNullOrEmpty(author.ImagePath))
        {
            author.ImagePath = "/Resource/Images/default.png";
        }
        Imagesource = new BitmapImage();
        Imagesource.BeginInit();
        Imagesource.UriSource = new Uri(author.ImagePath, UriKind.Relative);
        Imagesource.EndInit();

        if (string.IsNullOrEmpty(author.Description))
        {
            author.Description = @"“诗人”一词，战国时就有了，何以为证，《楚辞·九辩》注释说：“窃慕诗人之遗风兮，愿托志乎素餐。”可见早期诗人重在言志。《正字通》注释说：“屈原作离骚，言遭忧也，今谓诗人为骚人。”这便是“诗人”一词的最早提法。从此以后，“诗人”便成为两汉习用的名词。辞赋兴起之后，又产生“辞人”一词。扬雄《法言·吾子篇》说：“诗人之赋以则，辞人之赋丽以淫。”用“则”和“淫”来划分诗人与辞人的区别，足见在汉代是把“诗人”看得很高贵，把“辞人”看得比较低贱。
“诗人”和“辞人”是平等的。
六朝以后，社会上很看重辞赋，认为上不类诗，下不类赋，以此又创立了“骚人”一词。从战国至盛唐，“诗人”和“骚人”的称号一直受到人们的尊敬。";
        }
        Author = author;
    }
}
