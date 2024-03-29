﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    #region Enum kategorije
    public enum Kategorije
    {
        AM,
        A1,
        A2,
        A,
        B1,
        B,
        BE,
        C1,
        C1E,
        C,
        CE,
        D1,
        D1E,
        D,
        DE,
        F,
        M
    }
    #endregion
    public class Kategorija
    {
        #region Property
        public Kategorije KategorijaOznaka { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        #endregion
    }
}
