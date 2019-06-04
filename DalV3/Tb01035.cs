using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01035
    {
        public Tb01035()
        {
            Tb01008 = new HashSet<Tb01008>();
        }

        public DateTime? Tb01035Dtcad { get; set; }
        public string Tb01035Opcad { get; set; }
        public DateTime? Tb01035Dtalt { get; set; }
        public string Tb01035Opalt { get; set; }
        public string Tb01035Codigo { get; set; }
        public string Tb01035Nome { get; set; }
        public string Tb01035Situacao { get; set; }
        public string Tb01035Zona { get; set; }
        public string Tb01035Tipo { get; set; }
        public int? Tb01035Operacao { get; set; }
        public string Tb01035Status { get; set; }
        public string Tb01035Email { get; set; }
        public string Tb01035Status2 { get; set; }
        public int? Tb01035Tempo { get; set; }

        public virtual Tb01021 Tb01035StatusNavigation { get; set; }
        public virtual ICollection<Tb01008> Tb01008 { get; set; }
    }
}