using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01014
    {
        public Tb01014()
        {
            Tb01039 = new HashSet<Tb01039>();
            Tb01055 = new HashSet<Tb01055>();
            Tb02026 = new HashSet<Tb02026>();
            Tb02112 = new HashSet<Tb02112>();
            Tb02118 = new HashSet<Tb02118>();
            Tb02122 = new HashSet<Tb02122>();
            Tb02166 = new HashSet<Tb02166>();
            Tb02182 = new HashSet<Tb02182>();
            Tb02227 = new HashSet<Tb02227>();
        }

        public DateTime? Tb01014Dtcad { get; set; }
        public string Tb01014Opcad { get; set; }
        public DateTime? Tb01014Dtalt { get; set; }
        public string Tb01014Opalt { get; set; }
        public string Tb01014Codigo { get; set; }
        public int? Tb01014Dias { get; set; }
        public string Tb01014Ipi { get; set; }
        public string Tb01014Nome { get; set; }
        public int? Tb01014Numpar { get; set; }
        public decimal? Tb01014Perc { get; set; }
        public string Tb01014Situacao { get; set; }
        public int? Tb01014Tipoperc { get; set; }
        public int? Tb01014Tipovenc { get; set; }
        public string Tb01014Web { get; set; }
        public string Tb01014Datashop { get; set; }
        public string Tb01014Tipdoc { get; set; }

        public virtual ICollection<Tb01039> Tb01039 { get; set; }
        public virtual ICollection<Tb01055> Tb01055 { get; set; }
        public virtual ICollection<Tb02026> Tb02026 { get; set; }
        public virtual ICollection<Tb02112> Tb02112 { get; set; }
        public virtual ICollection<Tb02118> Tb02118 { get; set; }
        public virtual ICollection<Tb02122> Tb02122 { get; set; }
        public virtual ICollection<Tb02166> Tb02166 { get; set; }
        public virtual ICollection<Tb02182> Tb02182 { get; set; }
        public virtual ICollection<Tb02227> Tb02227 { get; set; }
    }
}