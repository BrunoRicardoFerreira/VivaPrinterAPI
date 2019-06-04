using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02108
    {
        public Tb02108()
        {
            Tb02109 = new HashSet<Tb02109>();
        }

        public DateTime? Tb02108Dtcad { get; set; }
        public string Tb02108Opcad { get; set; }
        public int Tb02108Trocaid { get; set; }
        public int Tb02108Prodid { get; set; }
        public string Tb02108Proent { get; set; }
        public string Tb02108Prodsai { get; set; }
        public decimal? Tb02108Qtent { get; set; }
        public decimal? Tb02108Qtsai { get; set; }
        public decimal? Tb02108Prent { get; set; }
        public decimal? Tb02108Prsai { get; set; }

        public virtual Tb01010 Tb02108ProdsaiNavigation { get; set; }
        public virtual Tb01010 Tb02108ProentNavigation { get; set; }
        public virtual Tb02107 Tb02108Troca { get; set; }
        public virtual ICollection<Tb02109> Tb02109 { get; set; }
    }
}