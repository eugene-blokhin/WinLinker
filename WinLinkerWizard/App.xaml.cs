using System.IO;
using System.Windows;
using WinLinker.WizardBase;
using WinLinker.WizardSteps;

namespace WinLinker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            var destinationPath = Path.GetDirectoryName(e.Args[0]);
            var linkDescriptor = new LinkDescriptor {DestinationPath = destinationPath};
            var initialStep = new LinkTypeWizardStep(linkDescriptor);
            var wizardWindow = new WizardWindow("Создание ссылки", initialStep);
            MainWindow = wizardWindow;
            MainWindow.Show();
        }
    }
}
