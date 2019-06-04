using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01080
    {
        public Tb01080()
        {
            Tb01081 = new HashSet<Tb01081>();
            Tb02160 = new HashSet<Tb02160>();
        }

        public DateTime? Tb01080Dtcad { get; set; }
        public string Tb01080Opcad { get; set; }
        public DateTime? Tb01080Dtalt { get; set; }
        public string Tb01080Opalt { get; set; }
        public string Tb01080Codigo { get; set; }
        public string Tb01080Nome { get; set; }
        public string Tb01080Codemp { get; set; }
        public string Tb01080Codserv { get; set; }
        public string Tb01080Vend { get; set; }
        public string Tb01080Tipodesc { get; set; }
        public string Tb01080Condpag { get; set; }
        public string Tb01080Status { get; set; }
        public string Tb01080Codtec { get; set; }
        public string Tb01080Tipo { get; set; }
        public string Tb01080Servint { get; set; }
        public string Tb01080Servext { get; set; }
        public string Tb01080Sistema { get; set; }
        public string Tb01080Implant { get; set; }
        public string Tb01080Projeto { get; set; }
        public int? Tb01080Tipoapura { get; set; }
        public string Tb01080Situacao { get; set; }
        public int? Tb01080Diasvenc { get; set; }
        public string Tb01080Codban { get; set; }
        public string Tb01080Codcon { get; set; }

        public virtual Tb04008 Tb01080CodbanNavigation { get; set; }
        public virtual Tb04009 Tb01080CodconNavigation { get; set; }
        public virtual Tb01007 Tb01080CodempNavigation { get; set; }
        public virtual Tb01005 Tb01080CodservNavigation { get; set; }
        public virtual Tb01024 Tb01080CodtecNavigation { get; set; }
        public virtual Tb01079 Tb01080TipoNavigation { get; set; }
        public virtual Tb01022 Tb01080TipodescNavigation { get; set; }
        public virtual Tb01006 Tb01080VendNavigation { get; set; }
        public virtual ICollection<Tb01081> Tb01081 { get; set; }
        public virtual ICollection<Tb02160> Tb02160 { get; set; }
    }
}