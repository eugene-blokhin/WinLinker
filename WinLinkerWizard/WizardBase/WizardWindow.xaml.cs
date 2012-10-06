using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WinLinker.WizardBase
{
    /// <summary>
    /// Interaction logic for WizardWindow.xaml
    /// </summary>
    public sealed partial class WizardWindow : Window
    {
        private WizardStep _currentStep;

        public WizardWindow(string title, WizardStep initialStep)
        {
            InitializeComponent();
            Title = title;
            SetStep(initialStep);
        }

        private void HandleClientTitleMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left && e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void SetStep(WizardStep step)
        {
            UpdateButtons(step);
            contentFrame.Navigate(step.Page);
        }

        private void UpdateButtons(WizardStep step)
        {
            buttonBar.Children.Clear();
            
            foreach (var buttonDescriptor in step.Buttons)
            {
                var descriptor = buttonDescriptor;

                var btn = new Button();
                btn.Content = buttonDescriptor.Text;
                btn.IsEnabled = buttonDescriptor.CanExecute;
                btn.Click += (_, __) => descriptor.Exetute();

                buttonBar.Children.Add(btn);
            }

            backBtn.IsEnabled = step.BackButton.CanExecute;
        }

        private void HandleBack(object sender, RoutedEventArgs e)
        {
            if (_currentStep.BackButton.CanExecute)
                _currentStep.BackButton.Exetute();
        }
    }
}
