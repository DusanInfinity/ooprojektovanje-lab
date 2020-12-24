using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Podaci
{
    [Serializable]
    public class ListaVozaca
    {
        #region Property
        private static ListaVozaca _instanca = null;
        private List<Vozac> _vozaci;

        public delegate void SortDelegat();
        [XmlIgnore] public SortDelegat SortDelegate { get; set; } = null;

        public List<Vozac> ListaSvihVozaca
        {
            get
            {
                return _vozaci;
            }
            private set // zbog XML-a
            {
                _vozaci = value;
            }
        }
        public static ListaVozaca Instanca
        {
            get
            {
                if (_instanca == null)
                {
                    ListaVozaca lista = Load();
                    if (lista != null)
                        _instanca = lista;
                    else
                        _instanca = new ListaVozaca();
                }

                return _instanca;
            }
        }
        #endregion

        #region Konstruktor
        public ListaVozaca()
        {
            _vozaci = new List<Vozac>();
        }
        #endregion

        #region Metode
        public bool DaLiPostojiBrojDozvole(string broj)
        {
            foreach (Vozac v in _vozaci)
            {
                if (v.BrVozackeDozvole == broj)
                    return true;
            }

            return false;
        }

        public Vozac VratiVozaca(string broj)
        {
            foreach (Vozac v in _vozaci)
            {
                if (v.BrVozackeDozvole == broj)
                    return v;
            }

            return null;
        }

        public bool Dodaj(Vozac vozac)
        {
            if (DaLiPostojiBrojDozvole(vozac.BrVozackeDozvole))
                return false;

            _vozaci.Add(vozac);
            Save();
            return true;
        }

        public bool IzmeniVozaca(string brVozackeDozvole, Vozac noviObj)
        {
            Vozac stariObj = VratiVozaca(brVozackeDozvole);
            if (stariObj == null)
                return false;

            stariObj.Ime = noviObj.Ime;
            stariObj.Prezime = noviObj.Prezime;
            stariObj.DatumRodjenja = noviObj.DatumRodjenja;
            stariObj.VazenjeDozvoleOd = noviObj.VazenjeDozvoleOd;
            stariObj.VazenjeDozvoleDo = noviObj.VazenjeDozvoleDo;
            stariObj.BrVozackeDozvole = noviObj.BrVozackeDozvole;
            stariObj.MestoIzdavanja = noviObj.MestoIzdavanja;
            stariObj.Pol = noviObj.Pol;
            stariObj.ImgPath = noviObj.ImgPath;
            stariObj.Kategorije = noviObj.Kategorije;
            stariObj.Zabrane = noviObj.Zabrane;
            Save();
            return true;
        }

        public bool ObrisiVozaca(Vozac vozac)
        {
            if (vozac == null || !DaLiPostojiBrojDozvole(vozac.BrVozackeDozvole))
                return false;

            _vozaci.Remove(vozac);
            Save();
            return true;
        }

        #region Cuvanje/Ucitavanje
        private void Save()
        {
            try
            {
                string fileName = Directory.GetCurrentDirectory() + "\\data.xml";
                using (XmlTextWriter wr = new XmlTextWriter(fileName, Encoding.Unicode))
                {             
                    XmlSerializer sr = new XmlSerializer(typeof(ListaVozaca));
                    sr.Serialize(wr, this);
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private static ListaVozaca Load()
        {
            try
            {
                string fileName = Directory.GetCurrentDirectory() + "\\data.xml";
                using (StreamReader rd = new StreamReader(fileName, Encoding.Unicode))
                {
                    XmlSerializer sr = new XmlSerializer(typeof(ListaVozaca));
                    ListaVozaca loadedData = (ListaVozaca)sr.Deserialize(rd);
                    return loadedData;
                }    
            }
            catch
            {
                return null;
            }
        }

        #endregion
        #endregion
    }
}
