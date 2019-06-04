using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04045
    {
        public DateTime? Tb04045Dtcad { get; set; }
        public string Tb04045Opcad { get; set; }
        public DateTime? Tb04045Dtalt { get; set; }
        public string Tb04045Opalt { get; set; }
        public string Tb04045Codigo { get; set; }
        public string Tb04045Codcli { get; set; }
        public string Tb04045Codemp { get; set; }
        public DateTime Tb04045Dtvenc { get; set; }
        public string Tb04045Tipodesc { get; set; }
        public string Tb04045Tipo { get; set; }
        public decimal? Tb04045Valor { get; set; }
        public decimal? Tb04045Valor2 { get; set; }

        public virtual Tb01074 Tb04045TipodescNavigation { get; set; }
    }
}