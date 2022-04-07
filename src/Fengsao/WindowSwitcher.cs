using System.Linq;
using System.Windows;

namespace Fengsao;

public static class WindowSwitcher
{
    public static void Switch<TClosed, TShow>() where TClosed : Window where TShow : Window, new()
    {
        Show<TShow>();
        Closed<TClosed>();
    }

    public static void Show<T>(T? window = null) where T : Window, new()
    {
        
        var shell = System.Windows.Application.Current.MainWindow = window ?? new T();
        shell?.Show();
    }

    public static void Closed<T>() where T : Window
    {
        var shell = System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault(window => window is T);
        shell?.Close();
    }
}
