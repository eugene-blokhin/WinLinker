using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WinLinker.WizardBase
{
    public abstract class WizardStep
    {
        public abstract ButtonDescriptor BackButton { get; }
        public abstract IEnumerable<ButtonDescriptor> Buttons { get; }
        public abstract Page Page { get; }

        public event EventHandler<NextStepEventArgs> NextStep;
        public event EventHandler CanExecuteInvalidated;

        protected void OnNextStep(NextStepEventArgs e)
        {
            var handler = NextStep;
            if (handler != null) 
                handler(this, e);
        }
        
        protected void OnCanExecuteInvalidated(EventArgs e)
        {
            var handler = CanExecuteInvalidated;
            if (handler != null) 
                handler(this, e);
        }
    }
}
