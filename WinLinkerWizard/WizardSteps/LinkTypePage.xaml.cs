using System;
using System.Windows.Controls;

namespace WinLinker.WizardSteps
{
    public sealed partial class LinkTypePage : Page
    {
        private readonly Action<LinkType> _typeSelectedCallback;

        public LinkTypePage(Action<LinkType> typeSelectedCallback)
        {
            _typeSelectedCallback = typeSelectedCallback;
            InitializeComponent();
        }

        private void HandleUseSymbolicLinks(object sender, System.Windows.RoutedEventArgs e)
        {
            _typeSelectedCallback(LinkType.SymbolicLink);
        }

        private void HandleUseHardLinks(object sender, System.Windows.RoutedEventArgs e)
        {
            _typeSelectedCallback(LinkType.HardLink);
        }
    }
}
