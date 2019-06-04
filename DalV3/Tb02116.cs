using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02116
    {
        public DateTime? Tb02116Dtcad { get; set; }
        public string Tb02116Opcad { get; set; }
        public DateTime? Tb02116Dtalt { get; set; }
        public string Tb02116Opalt { get; set; }
        public string Tb02116Codigo { get; set; }
        public string Tb02116Defeito { get; set; }
        public string Tb02116Obs { get; set; }

        public virtual Tb02115 Tb02116CodigoNavigation { get; set; }
        public virtual Tb01048 Tb02116DefeitoNavigation { get; set; }
    }
}