using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01091
    {
        public DateTime? Tb01091Dtcad { get; set; }
        public string Tb01091Opcad { get; set; }
        public DateTime? Tb01091Dtalt { get; set; }
        public string Tb01091Opalt { get; set; }
        public string Tb01091Codigo { get; set; }
        public string Tb01091Tipo { get; set; }
        public string Tb01091Motorista { get; set; }
        public string Tb01091Nome { get; set; }
        public string Tb01091Situacao { get; set; }

        public virtual Tb01077 Tb01091MotoristaNavigation { get; set; }
    }
}