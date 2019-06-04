using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01081
    {
        public DateTime? Tb01081Dtcad { get; set; }
        public string Tb01081Opcad { get; set; }
        public DateTime? Tb01081Dtalt { get; set; }
        public string Tb01081Opalt { get; set; }
        public string Tb01081Codcli { get; set; }
        public string Tb01081Codtipo { get; set; }
        public int? Tb01081Qtde { get; set; }
        public decimal? Tb01081Prunit { get; set; }
        public decimal? Tb01081Totvalor { get; set; }
        public DateTime? Tb01081Dtinicio { get; set; }
        public DateTime? Tb01081Dtcob { get; set; }
        public DateTime? Tb01081Dtvenc { get; set; }
        public int? Tb01081Diafat { get; set; }
        public int? Tb01081Franquia { get; set; }
        public string Tb01081Tipolan { get; set; }
        public int? Tb01081Diasvenc { get; set; }
        public DateTime? Tb01081Dtencerra { get; set; }
        public string Tb01081Motivo { get; set; }
        public string Tb01081Contrato { get; set; }

        public virtual Tb01008 Tb01081CodcliNavigation { get; set; }
        public virtual Tb01080 Tb01081CodtipoNavigation { get; set; }
    }
}