using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01068
    {
        public Tb01068()
        {
            Tb02018 = new HashSet<Tb02018>();
            Tb02021 = new HashSet<Tb02021>();
            Tb02227 = new HashSet<Tb02227>();
            Tb02230 = new HashSet<Tb02230>();
        }

        public DateTime? Tb01068Dtcad { get; set; }
        public string Tb01068Opcad { get; set; }
        public DateTime? Tb01068Dtalt { get; set; }
        public string Tb01068Opalt { get; set; }
        public string Tb01068Codigo { get; set; }
        public string Tb01068Nome { get; set; }
        public string Tb01068Situacao { get; set; }
        public string Tb01068Obs { get; set; }

        public virtual ICollection<Tb02018> Tb02018 { get; set; }
        public virtual ICollection<Tb02021> Tb02021 { get; set; }
        public virtual ICollection<Tb02227> Tb02227 { get; set; }
        public virtual ICollection<Tb02230> Tb02230 { get; set; }
    }
}