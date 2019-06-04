using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01039
    {
        public Tb01039()
        {
            Tb02030 = new HashSet<Tb02030>();
        }

        public DateTime? Tb01039Dtcad { get; set; }
        public string Tb01039Opcad { get; set; }
        public DateTime? Tb01039Dtalt { get; set; }
        public string Tb01039Opalt { get; set; }
        public string Tb01039Codigo { get; set; }
        public string Tb01039Nome { get; set; }
        public string Tb01039Situacao { get; set; }
        public string Tb01039Color { get; set; }
        public string Tb01039Color2 { get; set; }
        public string Tb01039Inicial { get; set; }
        public string Tb01039Gerarnf { get; set; }
        public string Tb01039Consulta { get; set; }
        public string Tb01039Fluxocx { get; set; }
        public string Tb01039Auditoria { get; set; }
        public string Tb01039Alterar { get; set; }
        public string Tb01039Entrega { get; set; }
        public string Tb01039Geraos { get; set; }
        public string Tb01039Statusos { get; set; }
        public string Tb01039Requisicao { get; set; }
        public string Tb01039Statusven { get; set; }
        public string Tb01039Vendedor { get; set; }
        public string Tb01039Tipodesc { get; set; }
        public string Tb01039Condpag { get; set; }
        public int? Tb01039Operacao { get; set; }

        public virtual Tb01014 Tb01039CondpagNavigation { get; set; }
        public virtual Tb01073 Tb01039StatusosNavigation { get; set; }
        public virtual Tb01021 Tb01039StatusvenNavigation { get; set; }
        public virtual Tb01022 Tb01039TipodescNavigation { get; set; }
        public virtual Tb01006 Tb01039VendedorNavigation { get; set; }
        public virtual ICollection<Tb02030> Tb02030 { get; set; }
    }
}