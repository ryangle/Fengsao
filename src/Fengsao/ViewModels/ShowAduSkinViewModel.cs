using Fengsao.Views;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;

namespace Fengsao.ViewModels;

public class ShowAduSkinViewModel : BindableBase
{
    private IRegionManager _regionMannager;
    private IContainerProvider _containerProvider;

    public DelegateCommand ShowFengsaoCommand { get; set; }
    void ShowFengsao()
    {
        var nextWindow = _containerProvider.Resolve<MainWindow>();
        var currentWindow = System.Windows.Application.Current.MainWindow;
        System.Windows.Application.Current.MainWindow = nextWindow;
        nextWindow.Show();
        currentWindow.Close();
    }
    public ShowAduSkinViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
    {
        ShowFengsaoCommand = new DelegateCommand(ShowFengsao);
        _regionMannager = regionManager;
        _containerProvider = containerProvider;
    }
}
