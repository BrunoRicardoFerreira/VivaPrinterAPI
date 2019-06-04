using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02084
    {
        public int Tb02084Codigo { get; set; }
        public int Tb02084Num { get; set; }
        public string Tb02084Tipo { get; set; }
        public string Tb02084Mes { get; set; }
        public decimal? Tb02084Qtdemeta { get; set; }
        public decimal? Tb02084Qtdereal { get; set; }
        public decimal? Tb02084Vlrmeta { get; set; }
        public decimal? Tb02084Vlrreal { get; set; }
        public string Tb02084Codigox { get; set; }
        public string Tb02084Codigoy { get; set; }
        public string Tb02084Nomex { get; set; }
        public string Tb02084Nomey { get; set; }

        public virtual Tb02083 Tb02084CodigoNavigation { get; set; }
    }
}