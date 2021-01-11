using System.Collections.Generic;

namespace Podaci
{
    public class SpilKarata
    {
        public List<Karta> Karte { get; set; } = new List<Karta>()
        {
            // 1/11
            new Karta(1, Karta.ZnakKarte.Herc, "_1H"),
            new Karta(1, Karta.ZnakKarte.Karo, "_1D"),
            new Karta(1, Karta.ZnakKarte.Tref, "_1C"),
            new Karta(1, Karta.ZnakKarte.Pik, "_1S"),

            // 2
            new Karta(2, Karta.ZnakKarte.Herc, "_2H"),
            new Karta(2, Karta.ZnakKarte.Karo, "_2D"),
            new Karta(2, Karta.ZnakKarte.Tref, "_2C"),
            new Karta(2, Karta.ZnakKarte.Pik, "_2S"),

            // 3
            new Karta(3, Karta.ZnakKarte.Herc, "_3H"),
            new Karta(3, Karta.ZnakKarte.Karo, "_3D"),
            new Karta(3, Karta.ZnakKarte.Tref, "_3C"),
            new Karta(3, Karta.ZnakKarte.Pik, "_3S"),

            // 4
            new Karta(4, Karta.ZnakKarte.Herc, "_4H"),
            new Karta(4, Karta.ZnakKarte.Karo, "_4D"),
            new Karta(4, Karta.ZnakKarte.Tref, "_4C"),
            new Karta(4, Karta.ZnakKarte.Pik, "_4S"),

            // 5
            new Karta(5, Karta.ZnakKarte.Herc, "_5H"),
            new Karta(5, Karta.ZnakKarte.Karo, "_5D"),
            new Karta(5, Karta.ZnakKarte.Tref, "_5C"),
            new Karta(5, Karta.ZnakKarte.Pik, "_5S"),

            // 6
            new Karta(6, Karta.ZnakKarte.Herc, "_6H"),
            new Karta(6, Karta.ZnakKarte.Karo, "_6D"),
            new Karta(6, Karta.ZnakKarte.Tref, "_6C"),
            new Karta(6, Karta.ZnakKarte.Pik, "_6S"),

            // 7
            new Karta(7, Karta.ZnakKarte.Herc, "_7H"),
            new Karta(7, Karta.ZnakKarte.Karo, "_7D"),
            new Karta(7, Karta.ZnakKarte.Tref, "_7C"),
            new Karta(7, Karta.ZnakKarte.Pik, "_7S"),

            // 8
            new Karta(8, Karta.ZnakKarte.Herc, "_8H"),
            new Karta(8, Karta.ZnakKarte.Karo, "_8D"),
            new Karta(8, Karta.ZnakKarte.Tref, "_8C"),
            new Karta(8, Karta.ZnakKarte.Pik, "_8S"),

            // 9
            new Karta(9, Karta.ZnakKarte.Herc, "_9H"),
            new Karta(9, Karta.ZnakKarte.Karo, "_9D"),
            new Karta(9, Karta.ZnakKarte.Tref, "_9C"),
            new Karta(9, Karta.ZnakKarte.Pik, "_9S"),

            // 10
            new Karta(10, Karta.ZnakKarte.Herc, "_10H"),
            new Karta(10, Karta.ZnakKarte.Karo, "_10D"),
            new Karta(10, Karta.ZnakKarte.Tref, "_10C"),
            new Karta(10, Karta.ZnakKarte.Pik, "_10S"),

            // 12/Zandar
            new Karta(12, Karta.ZnakKarte.Herc, "_12H"),
            new Karta(12, Karta.ZnakKarte.Karo, "_12D"),
            new Karta(12, Karta.ZnakKarte.Tref, "_12C"),
            new Karta(12, Karta.ZnakKarte.Pik, "_12S"),

            // 13/Dama
            new Karta(13, Karta.ZnakKarte.Herc, "_13H"),
            new Karta(13, Karta.ZnakKarte.Karo, "_13D"),
            new Karta(13, Karta.ZnakKarte.Tref, "_13C"),
            new Karta(13, Karta.ZnakKarte.Pik, "_13S"),

            // 14/Kralj
            new Karta(14, Karta.ZnakKarte.Herc, "_14H"),
            new Karta(14, Karta.ZnakKarte.Karo, "_14D"),
            new Karta(14, Karta.ZnakKarte.Tref, "_14C"),
            new Karta(14, Karta.ZnakKarte.Pik, "_14S"),
        };

        public bool IzbaciKartuIzSpila(int kartaIndex)
        {
            if (kartaIndex < 0 || kartaIndex >= Karte.Count)
                return false;

            Karte.RemoveAt(kartaIndex);
            return true;
        }
    }
}
