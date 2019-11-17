namespace PKaczorek.BL
{
    public class PAdres
    {
        public PAdres()
        {
            
        }

        public PAdres(int adresId)
        {
            adresId = AdresId;
        }

        public int AdresId { get; private set; }
        public int AdresTyp { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
    }
}