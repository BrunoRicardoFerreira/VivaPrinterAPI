using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01048
    {
        public Tb01048()
        {
            Tb02116 = new HashSet<Tb02116>();
        }

        public DateTime? Tb01048Dtcad { get; set; }
        public string Tb01048Opcad { get; set; }
        public DateTime? Tb01048Dtalt { get; set; }
        public DateTime? Tb01048Opalt { get; set; }
        public string Tb01048Codigo { get; set; }
        public string Tb01048Nome { get; set; }
        public string Tb01048Situacao { get; set; }
        public string Tb01048Obs { get; set; }
        public string Tb01048Solucao { get; set; }
        public string Tb01048Outsourcing { get; set; }
        public string Tb01048Ti { get; set; }
        public string Tb01048Sistemas { get; set; }
        public int? Tb01048Sla { get; set; }
        public int? Tb01048Tiposla { get; set; }

        public virtual ICollection<Tb02116> Tb02116 { get; set; }
    }
}