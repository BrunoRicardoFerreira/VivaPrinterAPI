using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02063
    {
        public Tb02063()
        {
            Tb02064 = new HashSet<Tb02064>();
            Tb02065 = new HashSet<Tb02065>();
            Tb02066 = new HashSet<Tb02066>();
            Tb02067 = new HashSet<Tb02067>();
            Tb02068 = new HashSet<Tb02068>();
        }

        public int Tb02063Cotacao { get; set; }
        public DateTime? Tb02063Data { get; set; }
        public string Tb02063Opcad { get; set; }
        public DateTime? Tb02063Dtfecha { get; set; }
        public string Tb02063Nome { get; set; }
        public string Tb02063Obs { get; set; }
        public string Tb02063Grupocodigo { get; set; }
        public string Tb02063Gruponome { get; set; }
        public string Tb02063Subgrupocodigo { get; set; }
        public string Tb02063Subgruponome { get; set; }
        public string Tb02063Forncodigo { get; set; }
        public string Tb02063Fornnome { get; set; }
        public string Tb02063Localcodigo { get; set; }
        public string Tb02063Localnome { get; set; }
        public string Tb02063Codemp { get; set; }
        public int? Tb02063Diasuteis { get; set; }
        public string Tb02063Tipo { get; set; }
        public string Tb02063Marcacodigo { get; set; }
        public string Tb02063Marcanome { get; set; }
        public string Tb02063Opcom { get; set; }
        public string Tb02063Compativeis { get; set; }

        public virtual Tb01007 Tb02063CodempNavigation { get; set; }
        public virtual Tb01078 Tb02063OpcomNavigation { get; set; }
        public virtual ICollection<Tb02064> Tb02064 { get; set; }
        public virtual ICollection<Tb02065> Tb02065 { get; set; }
        public virtual ICollection<Tb02066> Tb02066 { get; set; }
        public virtual ICollection<Tb02067> Tb02067 { get; set; }
        public virtual ICollection<Tb02068> Tb02068 { get; set; }
    }
}