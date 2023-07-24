using System.Windows;

namespace UZIP2
{
    /// <summary>
    /// YesNo.xaml 的交互逻辑
    /// </summary>
    public partial class YesNo : Window
    {
        public string YesContext
        {
            set { BOk.Content = value; }
        }
        public string NoContext
        {
            set { BCancel.Content = value; }
        }
        public string WindowTitle
        {
            set { this.Title = value; }
        }
        public string WindowTips
        {
            set { BTips.Content = value; }
        }
        public bool IsYes = false;
        public YesNo()
        {
            InitializeComponent();

        }

        private void BOk_Click(object sender, RoutedEventArgs e)
        {
            IsYes = true;
            this.Close();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            IsYes = false;
            this.Close();
        }
    }
}
