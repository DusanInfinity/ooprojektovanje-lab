using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace Podaci
{
    [Serializable]
    public class Vozac
    {
        #region Property
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [Browsable(false)] public DateTime DatumRodjenja { get; set; }
        [Browsable(false)] public DateTime VazenjeDozvoleOd { get; set; }
        [Browsable(false)] public DateTime VazenjeDozvoleDo { get; set; }
        [DisplayName("Br. vozacke dozvole")] public string BrVozackeDozvole { get; set; } // TO-DO string ili int?
        [Browsable(false)] public string MestoIzdavanja { get; set; }
        [Browsable(false)] public bool Pol { get; set; } // true - muski, false - zenski
        [Browsable(false)] public string ImgPath { get; set; }
        [Browsable(false)] public List<Kategorija> Kategorije { get; set; }
        [Browsable(false)] public List<Kategorija> Zabrane { get; set; }

        #endregion

        #region Konstruktori
        public Vozac()
        {

        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime vazenjeDozvoleOd, 
            DateTime vazenjeDozvoleDo, string brVozackeDozvole, string mestoIzdavanja, bool pol, 
            string imgPath, List<Kategorija> dozvole, List<Kategorija> zabrane)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            VazenjeDozvoleOd = vazenjeDozvoleOd;
            VazenjeDozvoleDo = vazenjeDozvoleDo;
            BrVozackeDozvole = brVozackeDozvole;
            MestoIzdavanja = mestoIzdavanja;
            Pol = pol;
            ImgPath = imgPath;
            Kategorije = dozvole;
            Zabrane = zabrane;
        }
        #endregion
    }
}
