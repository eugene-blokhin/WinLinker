namespace WinLinker.WizardSteps
{
    public enum LinkType
    {
        Invalid = 0,
        HardLink,
        SymbolicLink
    }

    class LinkDescriptor
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public string Filename { get; set; }
        public LinkType LinkType { get; set; }
    }
}
