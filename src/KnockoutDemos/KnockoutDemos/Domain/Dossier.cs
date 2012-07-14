namespace KnockoutDemos.Domain
{
    public class Dossier
    {
        public string DossierNumber { get; set; }

        public string OwnerLastName { get; set; }

        public string OwnerFirstName { get; set; }

        public string DetailLink
        {
            get { return string.Format("Dossier/Detail/{0}", DossierNumber); }
        }
    }
}