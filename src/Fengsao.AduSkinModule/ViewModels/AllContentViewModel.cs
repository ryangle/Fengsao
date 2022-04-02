using Fengsao.AduSkinModule.Enum;
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
    private ObservableCollection<ControlModel>? _allMenus;
    public ObservableCollection<ControlModel>? AllMenus
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
    private ControlModel _CurrentShowControl;
    /// <summary>
    /// 当前显示控件
    /// </summary>
    public ControlModel CurrentShowControl
    {
        get { return _CurrentShowControl; }
        set
        {
            SetProperty(ref _CurrentShowControl, value);
        }
    }
    public AllContentViewModel(FengsaoService fengsaoService)
    {
        AllMenus = new ObservableCollection<ControlModel>()
        {
            //new ControlModel("Win10菜单", typeof(SortGroup)),
            //new ControlModel("图片上传", typeof(UploadPic)),
            //new ControlModel("视频控件", typeof(VideoPlayer)),
            new ControlModel("折叠菜单", typeof(ExpanderMenu)),
            new ControlModel("导航容器", typeof(NavigationPanel)),
            new ControlModel("轮播容器", typeof(CarouselContainer)),
            new ControlModel("封面流", typeof(CoverFlowDemo)),
            new ControlModel("时间轴", typeof(TimeLine)),
            new ControlModel("时间线", typeof(TimeBarDemo)),
            new ControlModel("树形菜单", typeof(TreeMenu)),
            new ControlModel("数据列表", typeof(DataGridDemo)),
            new ControlModel("多功能Tab", typeof(MultiFunctionTabControl)),
            //new ControlModel("右键菜单", typeof(ContextMenuDemo), DemoType.Demo),
            //new ControlModel("右侧弹框", typeof(NoticeDemo)),
            //new ControlModel("过渡容器", typeof(TransitioningContentControlDemo), DemoType.Demo),
            //new ControlModel("消息弹框", typeof(MessageBoxDemo), DemoType.Demo, ControlState.New),
         };
    }

}
