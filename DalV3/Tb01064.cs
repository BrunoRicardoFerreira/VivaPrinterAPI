using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01064
    {
        public Tb01064()
        {
            Tb01005 = new HashSet<Tb01005>();
        }

        public string Tb01064Codigo { get; set; }
        public string Tb01064Subitem { get; set; }
        public string Tb01064Descricao { get; set; }
        public DateTime? Tb01064Dtcad { get; set; }
        public string Tb01064Opcad { get; set; }
        public DateTime? Tb01064Dtalt { get; set; }
        public string Tb01064Opalt { get; set; }
        public string Tb01064Situacao { get; set; }
        public string Tb01064Idloctrib { get; set; }
        public decimal? Tb01064Percibpt { get; set; }

        public virtual ICollection<Tb01005> Tb01005 { get; set; }
    }
}