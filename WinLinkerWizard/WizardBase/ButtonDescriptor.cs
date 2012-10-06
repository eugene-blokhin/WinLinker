using System;

namespace WinLinker.WizardBase
{
    public struct ButtonDescriptor
    {
        public string Text;
        public bool CanExecute;
        public Action Exetute;
    }
}