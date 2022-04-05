using Fengsao.AduSkinModule.Models;
using Fengsao.AduSkinModule.Views;
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

public class AllContentViewModel : BindableBase
{
    private ObservableCollection<MenuModel>? _allMenus;
    public ObservableCollection<MenuModel>? AllMenus
    {
        get { return _allMenus; }
        set { SetProperty(ref _allMenus, value); }
    }
    private int _SelectedDemoType;
    /// <summary>
    /// 当前列表显示类型
    /// </summary>
    public int SelectedDemoType
    {
        get { return _SelectedDemoType; }
        set { SetProperty(ref _SelectedDemoType, value); }
    }
    private MenuModel _CurrentShowControl;
    private string _title;
    public string Title
    {
        get { return _title; }
        set { SetProperty(ref _title, value); }
    }
    /// <summary>
    /// 当前显示控件
    /// </summary>
    public MenuModel CurrentShowControl
    {
        get { return _CurrentShowControl; }
        set
        {
            SetProperty(ref _CurrentShowControl, value);
        }
    }
    public DelegateCommand<string> ShowControlCommand { get; private set; }
    private readonly IRegionManager _regionManager;
    public AllContentViewModel(FengsaoService fengsaoService, IRegionManager regionManager)
    {
        ShowControlCommand = new DelegateCommand<string>(ShowControl);
        _regionManager = regionManager;
        AllMenus = new ObservableCollection<MenuModel>()
        {
            new MenuModel("Win10菜单", typeof(SortGroup)),
            //new MenuModel("图片上传", typeof(UploadPic)),
            //new MenuModel("视频控件", typeof(VideoPlayer)),
            new MenuModel("折叠菜单", typeof(ExpanderMenu)),
            new MenuModel("导航容器", typeof(NavigationPanel)),
            new MenuModel("轮播容器", typeof(CarouselContainer)),
            new MenuModel("封面流", typeof(CoverFlowDemo)),
            new MenuModel("时间轴", typeof(TimeLine)),
            new MenuModel("时间线", typeof(TimeBarDemoView)),
            new MenuModel("树形菜单", typeof(TreeMenu)),
            new MenuModel("数据列表", typeof(DataGridDemo)),
            new MenuModel("多功能Tab", typeof(MultiFunctionTabControl)),
            new MenuModel("右键菜单", typeof(ContextMenuDemo), DemoType.Demo),
            //new MenuModel("右侧弹框", typeof(NoticeDemo)),
            new MenuModel("过渡容器", typeof(TransitioningContentControlDemo), DemoType.Demo),
            //new MenuModel("消息弹框", typeof(MessageBoxDemo), DemoType.Demo, ControlState.New),
         };
    }
    private void ShowControl(string controlTitle)
    {
        Title = controlTitle;
        var menu = AllMenus?.First(m => m.Title == controlTitle);
        if (menu != null)
        {
            _regionManager.RequestNavigate("ContentRegion", menu.Content.Name);
        }
    }
}
