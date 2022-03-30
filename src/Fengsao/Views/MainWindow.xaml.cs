using System.Windows;
using Prism.Ioc;
using Prism.Regions;
using AduSkin.Controls.Metro;
using Fengsao.Views;

namespace Fengsao.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.Closed += delegate { System.Windows.Application.Current.Shutdown(); };
            Theme.ColorChange += (s, e) =>
            {
                // 不要通过XAML来绑定颜色，无法获取到通知
                BorderBrush = Theme.CurrentColor.OpaqueSolidColorBrush;
            };
        }
    }
}
