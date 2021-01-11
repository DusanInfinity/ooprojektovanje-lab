namespace Podaci
{
    public class Karta
    {
        public enum ZnakKarte
        {
            Herc,
            Karo,
            Tref,
            Pik
        }
        public int Broj { get; set; }
        public ZnakKarte Znak { get; set; }
        public string Slika { get; set; }

        public Karta(byte broj, ZnakKarte znak, string slika)
        {
            Broj = broj;
            Znak = znak;
            Slika = slika;
        }
    }
}
