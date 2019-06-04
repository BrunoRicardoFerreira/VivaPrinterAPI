using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01045
    {
        public string Tb01045Codigox { get; set; }
        public string Tb01045Codigoy { get; set; }
        public string Tb01045Contabil { get; set; }
        public string Tb01045Nomex { get; set; }
        public string Tb01045Nomey { get; set; }
        public string Tb01045Tipdesc { get; set; }
        public decimal? Tb01045Desconto { get; set; }
        public decimal? Tb01045Acrescimo { get; set; }
        public string Tb01045Codemp { get; set; }
        public decimal? Tb01045Comissao { get; set; }
        public string Tb01045Formapreco { get; set; }
        public decimal? Tb01045Markup { get; set; }
        public string Tb01045Tipodesc { get; set; }
        public decimal? Tb01045Plus { get; set; }

        public virtual Tb01007 Tb01045CodempNavigation { get; set; }
    }
}