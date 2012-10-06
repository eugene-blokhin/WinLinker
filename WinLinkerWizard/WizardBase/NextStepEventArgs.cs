using System;

namespace WinLinker.WizardBase
{
    public class NextStepEventArgs : EventArgs
    {
        public NextStepEventArgs(WizardStep nextStep)
        {
            NextStep = nextStep;
        }

        public WizardStep NextStep { get; private set; }
    }
}