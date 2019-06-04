using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01012
    {
        public Tb01012()
        {
            Tb02002 = new HashSet<Tb02002>();
            Tb02005 = new HashSet<Tb02005>();
            Tb02007 = new HashSet<Tb02007>();
            Tb02009 = new HashSet<Tb02009>();
            Tb02011 = new HashSet<Tb02011>();
            Tb02013 = new HashSet<Tb02013>();
            Tb02015 = new HashSet<Tb02015>();
            Tb02030 = new HashSet<Tb02030>();
            Tb02048 = new HashSet<Tb02048>();
            Tb02050 = new HashSet<Tb02050>();
            Tb02057 = new HashSet<Tb02057>();
            Tb02059 = new HashSet<Tb02059>();
            Tb02073 = new HashSet<Tb02073>();
            Tb02075 = new HashSet<Tb02075>();
            Tb02077 = new HashSet<Tb02077>();
            Tb02079 = new HashSet<Tb02079>();
            Tb02088 = new HashSet<Tb02088>();
            Tb02100 = new HashSet<Tb02100>();
            Tb02144 = new HashSet<Tb02144>();
        }

        public DateTime? Tb01012Dtcad { get; set; }
        public string Tb01012Opcad { get; set; }
        public DateTime? Tb01012Dtalt { get; set; }
        public string Tb01012Opalt { get; set; }
        public string Tb01012Codigo { get; set; }
        public int? Tb01012Dias { get; set; }
        public string Tb01012Ipi { get; set; }
        public string Tb01012Nome { get; set; }
        public int? Tb01012Numpar { get; set; }
        public decimal? Tb01012Perc { get; set; }
        public string Tb01012Situacao { get; set; }
        public int? Tb01012Tipoperc { get; set; }
        public int? Tb01012Tipovenc { get; set; }
        public string Tb01012Tipdoc { get; set; }

        public virtual ICollection<Tb02002> Tb02002 { get; set; }
        public virtual ICollection<Tb02005> Tb02005 { get; set; }
        public virtual ICollection<Tb02007> Tb02007 { get; set; }
        public virtual ICollection<Tb02009> Tb02009 { get; set; }
        public virtual ICollection<Tb02011> Tb02011 { get; set; }
        public virtual ICollection<Tb02013> Tb02013 { get; set; }
        public virtual ICollection<Tb02015> Tb02015 { get; set; }
        public virtual ICollection<Tb02030> Tb02030 { get; set; }
        public virtual ICollection<Tb02048> Tb02048 { get; set; }
        public virtual ICollection<Tb02050> Tb02050 { get; set; }
        public virtual ICollection<Tb02057> Tb02057 { get; set; }
        public virtual ICollection<Tb02059> Tb02059 { get; set; }
        public virtual ICollection<Tb02073> Tb02073 { get; set; }
        public virtual ICollection<Tb02075> Tb02075 { get; set; }
        public virtual ICollection<Tb02077> Tb02077 { get; set; }
        public virtual ICollection<Tb02079> Tb02079 { get; set; }
        public virtual ICollection<Tb02088> Tb02088 { get; set; }
        public virtual ICollection<Tb02100> Tb02100 { get; set; }
        public virtual ICollection<Tb02144> Tb02144 { get; set; }
    }
}