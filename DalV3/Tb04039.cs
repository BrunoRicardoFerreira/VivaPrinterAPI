using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04039
    {
        public int Tb04039Lote { get; set; }
        public string Tb04039Codcli { get; set; }
        public string Tb04039Codemp { get; set; }
        public string Tb04039Codigo { get; set; }
        public string Tb04039Tipdoc { get; set; }
        public DateTime? Tb04039Dtvenc { get; set; }
        public decimal? Tb04039Vlrtitulo { get; set; }
        public DateTime? Tb04039Dataop { get; set; }
        public int? Tb04039Status { get; set; }

        public virtual Tb04010 Tb04039Cod { get; set; }
        public virtual Tb01008 Tb04039CodcliNavigation { get; set; }
        public virtual Tb01007 Tb04039CodempNavigation { get; set; }
        public virtual Tb04038 Tb04039LoteNavigation { get; set; }
    }
}