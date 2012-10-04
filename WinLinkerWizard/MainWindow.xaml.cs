using System.Windows;
using System.Windows.Input;

namespace WinLinker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleClientTitleMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left && e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
