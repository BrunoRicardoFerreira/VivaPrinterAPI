using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02177
    {
        public Tb02177()
        {
            Tb02018 = new HashSet<Tb02018>();
            Tb02021 = new HashSet<Tb02021>();
            Tb02227 = new HashSet<Tb02227>();
        }

        public DateTime? Tb02177Dtcad { get; set; }
        public string Tb02177Opcad { get; set; }
        public DateTime? Tb02177Dtalt { get; set; }
        public string Tb02177Opalt { get; set; }
        public string Tb02177Codigo { get; set; }
        public string Tb02177Codcli { get; set; }
        public int? Tb02177Id { get; set; }
        public string Tb02177Nome { get; set; }
        public int? Tb02177Site { get; set; }
        public string Tb02177Integra { get; set; }
        public string Tb02177Codsite { get; set; }

        public virtual ICollection<Tb02018> Tb02018 { get; set; }
        public virtual ICollection<Tb02021> Tb02021 { get; set; }
        public virtual ICollection<Tb02227> Tb02227 { get; set; }
    }
}