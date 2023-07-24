using System.Windows;

namespace UZIP2
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void OnAppStartup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length != 0)
            {
                USetting.FileList = e.Args;
                USetting.IsCmdMode = true;
            }
        }
    }
}
