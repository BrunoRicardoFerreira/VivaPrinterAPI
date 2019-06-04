using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01044
    {
        public Tb01044()
        {
            Tb01061Tb01061NovostatusNavigation = new HashSet<Tb01061>();
            Tb01061Tb01061StatusNavigation = new HashSet<Tb01061>();
            Tb01062 = new HashSet<Tb01062>();
            Tb02102Tb02102StatusNavigation = new HashSet<Tb02102>();
            Tb02102Tb02102StatusatuNavigation = new HashSet<Tb02102>();
            Tb02137 = new HashSet<Tb02137>();
        }

        public DateTime? Tb01044Dtcad { get; set; }
        public string Tb01044Opcad { get; set; }
        public DateTime? Tb01044Dtalt { get; set; }
        public string Tb01044Opalt { get; set; }
        public string Tb01044Codigo { get; set; }
        public string Tb01044Nome { get; set; }
        public string Tb01044Situacao { get; set; }
        public int? Tb01044Dias { get; set; }
        public string Tb01044Alterar { get; set; }
        public string Tb01044Color { get; set; }
        public string Tb01044Concluir { get; set; }
        public string Tb01044Pedirsenha { get; set; }
        public string Tb01044Senha { get; set; }
        public string Tb01044Troca { get; set; }
        public string Tb01044Inicial { get; set; }

        public virtual ICollection<Tb01061> Tb01061Tb01061NovostatusNavigation { get; set; }
        public virtual ICollection<Tb01061> Tb01061Tb01061StatusNavigation { get; set; }
        public virtual ICollection<Tb01062> Tb01062 { get; set; }
        public virtual ICollection<Tb02102> Tb02102Tb02102StatusNavigation { get; set; }
        public virtual ICollection<Tb02102> Tb02102Tb02102StatusatuNavigation { get; set; }
        public virtual ICollection<Tb02137> Tb02137 { get; set; }
    }
}