using System;
using System.Collections.Generic;

namespace Podaci
{
    public class Igra
    {
        #region Property, konstruktor
        public int BrPoena { get; set; }
        public int Ulog { get; set; }
        public List<Karta> IzabraneKarte { get; set; }
        public byte Zamene { get; set; }
        public SpilKarata Spil { get; set; }
        private readonly Random rand = new Random();

        public Igra(int brPoena, int ulog)
        {
            BrPoena = brPoena;
            Ulog = ulog;
            Zamene = 3; // broj preostalih zamena
        }
        #endregion

        #region Manipulacija sa izabranim kartama
        public void PokreniIgru()
        {
            IzabraneKarte = new List<Karta>(5) { null, null, null, null, null };

            Spil = new SpilKarata();
            BrPoena -= Ulog;

            for (int i = 0; i < 5; i++)
                IzaberiKartu(i);
        }
        private void IzaberiKartu(int redniBroj)
        {
            List<Karta> spil = Spil.Karte;
            int kartaIndex = rand.Next(spil.Count);
            IzabraneKarte[redniBroj] = spil[kartaIndex];
            Spil.IzbaciKartuIzSpila(kartaIndex);
        }

        public void ZameniKartu(int redniBroj)
        {
            if (redniBroj < 0 || redniBroj > 4 || IzabraneKarte[redniBroj] == null)
                return;

            IzaberiKartu(redniBroj);
        }

        public Tuple<string, int> VratiIshod()
        {
            string ime = "/";
            int koeficijent = 0;

            if (Check_IsStraightFlush())
            {
                ime = "Straight Flush";
                koeficijent = 100;
            }
            else if (Check_IsFourOfAKind())
            {
                ime = "Four of a kind";
                koeficijent = 60;
            }
            else if (Check_IsBigBobtail())
            {
                ime = "Big bobtail";
                koeficijent = 40;
            }
            else if (Check_IsFullHouse())
            {
                ime = "Full house";
                koeficijent = 24;
            }
            else if (Check_IsFlush())
            {
                ime = "Flush";
                koeficijent = 16;
            }
            else if (Check_IsStraight())
            {
                ime = "Straight";
                koeficijent = 12;
            }
            else if (Check_IsBlaze())
            {
                ime = "Blaze";
                koeficijent = 9;
            }
            else if (Check_IsThreeOfAKind())
            {
                ime = "Three of a kind";
                koeficijent = 6;
            }
            else if (Check_IsTwoPair())
            {
                ime = "Two pair";
                koeficijent = 4;
            }
            else if (Check_IsOnePair())
            {
                ime = "One pair";
                koeficijent = 2;
            }

            return new Tuple<string, int>(ime, koeficijent);
        }

        #endregion

        #region Pomocne metode za odredjivanje ishoda
        private Karta PronadjiNajvecu()
        {
            Karta najveca = IzabraneKarte[0];

            for (int i = 1; i < 5; i++)
            {
                if (najveca.Broj < IzabraneKarte[i].Broj)
                {
                    if (najveca.Broj != 1 || IzabraneKarte[i].Broj > 11) // Provera zbog A (1)
                    {
                        najveca = IzabraneKarte[i];
                    }
                }
            }

            return najveca;
        }

        private Karta PronadjiManju(int broj)
        {
            Karta najveca = null;

            for (int i = 0; i < 5; i++)
            {
                if (IzabraneKarte[i].Broj < broj)
                {
                    if (najveca == null)
                        najveca = IzabraneKarte[i];
                    else if (najveca.Broj < IzabraneKarte[i].Broj)
                    {
                        if (najveca.Broj != 1 || IzabraneKarte[i].Broj > 11) // Provera zbog A (1)
                        {
                            najveca = IzabraneKarte[i];
                        }
                    }
                }
            }

            return najveca;
        }

        private int VratiBrojKarata(int broj)
        {
            int br = 0;
            foreach (Karta k in IzabraneKarte)
            {
                if (k.Broj == broj || broj == 11 && k.Broj == 1)
                    br++;
            }

            return br;
        }
        private int VratiBrojKarata(Karta.ZnakKarte znak)
        {
            int br = 0;
            foreach (Karta k in IzabraneKarte)
            {
                if (k.Znak == znak)
                    br++;
            }

            return br;
        }

        private bool PronadjiKartu(int broj)
        {
            foreach (Karta k in IzabraneKarte)
            {
                if (k.Broj == broj || broj == 11 && k.Broj == 1)
                    return true;
            }
            return false;
        }

        private bool PronadjiKartu(int broj, Karta.ZnakKarte znak)
        {
            foreach (Karta k in IzabraneKarte)
            {
                if (k.Znak == znak && (k.Broj == broj || broj == 11 && k.Broj == 1))
                    return true;
            }
            return false;
        }
        #endregion 

        #region Poker provere
        private bool Check_IsStraightFlush()
        {
            Karta najveca = PronadjiNajvecu();

            int najvecaBr = (najveca.Broj == 1) ? 11 : najveca.Broj; // Provera zbog A

            for (int i = 1; i <= 4; i++)
            {
                if (!PronadjiKartu(najvecaBr - i, najveca.Znak))
                    return false;
            }

            return true;
        }

        private bool Check_IsFourOfAKind()
        {
            for (int i = 1; i <= 14; i++)
            {
                int br = VratiBrojKarata(i);
                if (br == 4)
                    return true;
                else if (br >= 2)
                    return false;
            }

            return false;
        }
        private bool Check_IsBigBobtail()
        {
            int najvecaBr = 15;

            bool pronasao = false;

            for (int k = 0; k < 2; k++)
            {
                Karta najveca = PronadjiManju(najvecaBr);
                if (najveca == null)
                    return false;

                najvecaBr = najveca.Broj;
                pronasao = true;
                for (int i = 1; i <= 3; i++)
                {
                    if (!PronadjiKartu(najvecaBr - i, najveca.Znak))
                        pronasao = false;
                }
            }

            return pronasao;
        }

        private bool Check_IsFullHouse()
        {
            bool triIste = false, dveIste = false;

            for (int i = 1; i <= 14; i++)
            {
                int br = VratiBrojKarata(i);
                if (br == 2)
                    dveIste = true;
                else if (br == 3)
                    triIste = true;

            }

            return dveIste && triIste;
        }

        private bool Check_IsFlush()
        {
            foreach (Karta.ZnakKarte znak in Enum.GetValues(typeof(Karta.ZnakKarte)))
            {
                if (VratiBrojKarata(znak) == 5)
                    return true;
            }
            return false;
        }

        private bool Check_IsStraight() // isto kao Flush Straight, samo bez provere znaka
        {
            Karta najveca = PronadjiNajvecu();

            int najvecaBr = (najveca.Broj == 1) ? 11 : najveca.Broj; // Provera zbog A

            for (int i = 1; i <= 4; i++)
            {
                if (!PronadjiKartu(najvecaBr - i))
                    return false;
            }

            return true;
        }

        private bool Check_IsBlaze() // sve karte zandari(12), dame(13) ili kraljevi(14)
        {
            foreach (Karta k in IzabraneKarte)
            {
                if (k.Broj < 12)
                    return false;
            }

            return true;
        }

        private bool Check_IsThreeOfAKind() // Tri karte sa istim brojem
        {
            bool triIste = false;

            for (int i = 1; i <= 14; i++)
            {
                int br = VratiBrojKarata(i);
                if (br == 3)
                    triIste = true;
            }

            return triIste;
        }

        private bool Check_IsTwoPair() // Dva para
        {
            bool prviPar = false, drugiPar = false;

            for (int i = 1; i <= 14; i++)
            {
                int br = VratiBrojKarata(i);
                if (br == 2)
                {
                    if (prviPar)
                        drugiPar = true;
                    else
                        prviPar = true;
                }
            }

            return prviPar && drugiPar;
        }

        private bool Check_IsOnePair() // Jedan par
        {
            for (int i = 1; i <= 14; i++)
            {
                int br = VratiBrojKarata(i);
                if (br == 2)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
