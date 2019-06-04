using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04042
    {
        public int Tb04042Lote { get; set; }
        public string Tb04042Codcli { get; set; }
        public string Tb04042Codemp { get; set; }
        public string Tb04042Codigo { get; set; }
        public string Tb04042Tipdoc { get; set; }
        public DateTime? Tb04042Dtvenc { get; set; }
        public decimal? Tb04042Vlrtitulo { get; set; }
        public int? Tb04042Status { get; set; }

        public virtual Tb04010 Tb04042Cod { get; set; }
        public virtual Tb01008 Tb04042CodcliNavigation { get; set; }
        public virtual Tb01007 Tb04042CodempNavigation { get; set; }
        public virtual Tb04041 Tb04042LoteNavigation { get; set; }
    }
}