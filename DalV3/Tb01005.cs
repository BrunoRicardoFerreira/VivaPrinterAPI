using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01005
    {
        public Tb01005()
        {
            Tb01080 = new HashSet<Tb01080>();
            Tb02125 = new HashSet<Tb02125>();
            Tb02190 = new HashSet<Tb02190>();
        }

        public DateTime? Tb01005Dtcad { get; set; }
        public string Tb01005Opcad { get; set; }
        public DateTime? Tb01005Dtalt { get; set; }
        public string Tb01005Opalt { get; set; }
        public string Tb01005Codigo { get; set; }
        public string Tb01005Nome { get; set; }
        public string Tb01005Situacao { get; set; }
        public decimal? Tb01005Valor { get; set; }
        public decimal? Tb01005Vlrcomissao { get; set; }
        public decimal? Tb01005Aliqiss { get; set; }
        public decimal? Tb01005Aliqpis { get; set; }
        public decimal? Tb01005Aliqcofins { get; set; }
        public decimal? Tb01005Aliqcsll { get; set; }
        public decimal? Tb01005Aliqir { get; set; }
        public decimal? Tb01005Aliqimpfat { get; set; }
        public string Tb01005Obs { get; set; }
        public string Tb01005Codcen { get; set; }
        public string Tb01005Codsub { get; set; }
        public string Tb01005Plancon { get; set; }
        public decimal? Tb01005Custo { get; set; }
        public string Tb01005Frete { get; set; }
        public string Tb01005Cstpis { get; set; }
        public string Tb01005Cstcofins { get; set; }
        public string Tb01005Retpis { get; set; }
        public string Tb01005Retcofins { get; set; }
        public string Tb01005Retcsll { get; set; }
        public string Tb01005Retir { get; set; }
        public string Tb01005Retiss { get; set; }
        public string Tb01005Codtributacao { get; set; }
        public string Tb01005Subitem { get; set; }
        public string Tb01005Natret { get; set; }
        public string Tb01005Retinss { get; set; }
        public decimal? Tb01005Comissao { get; set; }
        public string Tb01005Prestado { get; set; }
        public string Tb01005Tomado { get; set; }
        public string Tb01005Tecnico { get; set; }
        public string Tb01005Cnae { get; set; }

        public virtual Tb04004 Tb01005CodcenNavigation { get; set; }
        public virtual Tb04005 Tb01005CodsubNavigation { get; set; }
        public virtual Tb01063 Tb01005CodtributacaoNavigation { get; set; }
        public virtual Tb01064 Tb01005Navigation { get; set; }
        public virtual Tb04006 Tb01005PlanconNavigation { get; set; }
        public virtual ICollection<Tb01080> Tb01080 { get; set; }
        public virtual ICollection<Tb02125> Tb02125 { get; set; }
        public virtual ICollection<Tb02190> Tb02190 { get; set; }
    }
}