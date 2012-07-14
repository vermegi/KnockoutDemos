using KnockoutDemos.Domain;

namespace KnockoutDemos.ViewModels
{
    public class ScanViewModel
    {
        public ScanViewModel(Scan scan, Dossier dossier)
        {
            Scan = scan;
            Dossier = dossier;
        }

        public Dossier Dossier { get; private set; }

        public Scan Scan { get; private set; }
    }
}