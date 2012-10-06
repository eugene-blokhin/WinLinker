using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WinLinker.WizardBase;

namespace WinLinker.WizardSteps
{
    sealed class LinkTypeWizardStep : WizardStep
    {
        private readonly LinkTypePage _page;
        private readonly LinkDescriptor _linkDescriptor;
        private readonly ButtonDescriptor _backButton = new ButtonDescriptor {CanExecute = false};
        private readonly ButtonDescriptor[] _buttons;

        public LinkTypeWizardStep(LinkDescriptor linkDescriptor)
        {
            _linkDescriptor = linkDescriptor;
            _page = new LinkTypePage(HandleLinkTypeSelected);
            _buttons = new[] { new ButtonDescriptor{CanExecute = true, Exetute = HandleCancel, Text = "Отмена"} };
        }

        public override ButtonDescriptor BackButton 
        {
            get { return _backButton; }
        }

        public override IEnumerable<ButtonDescriptor> Buttons
        {
            get { return _buttons; }
        }

        public override Page Page
        {
            get { return _page; }
        }

        private void HandleLinkTypeSelected(LinkType obj)
        {

        }

        private void HandleCancel()
        {
            Application.Current.Shutdown(0);
        }
    }
}
