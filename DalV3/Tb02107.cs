using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02107
    {
        public Tb02107()
        {
            Tb02108 = new HashSet<Tb02108>();
        }

        public DateTime? Tb02107Dtcad { get; set; }
        public string Tb02107Opcad { get; set; }
        public int Tb02107Trocaid { get; set; }
        public DateTime? Tb02107Data { get; set; }
        public string Tb02107Opentrada { get; set; }
        public string Tb02107Opsaida { get; set; }
        public string Tb02107Ajentrada { get; set; }
        public string Tb02107Ajsaida { get; set; }
        public string Tb02107Nome { get; set; }
        public string Tb02107Codemp { get; set; }
        public string Tb02107Numcredito { get; set; }
        public string Tb02107Codcli { get; set; }

        public virtual Tb01008 Tb02107CodcliNavigation { get; set; }
        public virtual ICollection<Tb02108> Tb02108 { get; set; }
    }
}