using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01092
    {
        public string Tb01092Tipodesc { get; set; }
        public int? Tb01092Operacao { get; set; }
        public string Tb01092Statusinicial { get; set; }
        public string Tb01092Statusres { get; set; }
        public string Tb01092Statustirares { get; set; }
        public string Tb01092Statusntfisc { get; set; }
        public string Tb01092Statusenvntfisc { get; set; }
        public string Tb01092Statuscanntfisc { get; set; }
        public string Tb01092Statusexpedicao { get; set; }
        public string Tb01092Statusautoriza { get; set; }
        public string Tb01092Statustec { get; set; }
        public string Tb01092Statussaida { get; set; }
        public string Tb01092Statusretorno { get; set; }
        public string Tb01092Statusentrega { get; set; }

        public virtual Tb01021 Tb01092StatusautorizaNavigation { get; set; }
        public virtual Tb01021 Tb01092StatuscanntfiscNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusentregaNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusenvntfiscNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusexpedicaoNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusinicialNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusntfiscNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusresNavigation { get; set; }
        public virtual Tb01021 Tb01092StatusretornoNavigation { get; set; }
        public virtual Tb01021 Tb01092StatussaidaNavigation { get; set; }
        public virtual Tb01021 Tb01092StatustecNavigation { get; set; }
        public virtual Tb01021 Tb01092StatustiraresNavigation { get; set; }
        public virtual Tb01022 Tb01092TipodescNavigation { get; set; }
    }
}