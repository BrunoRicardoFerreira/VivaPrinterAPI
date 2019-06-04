using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01078
    {
        public Tb01078()
        {
            Tb02002 = new HashSet<Tb02002>();
            Tb02003 = new HashSet<Tb02003>();
            Tb02030 = new HashSet<Tb02030>();
            Tb02031 = new HashSet<Tb02031>();
            Tb02063 = new HashSet<Tb02063>();
            Tb02073 = new HashSet<Tb02073>();
            Tb02074 = new HashSet<Tb02074>();
        }

        public DateTime? Tb01078Dtcad { get; set; }
        public string Tb01078Opcad { get; set; }
        public DateTime? Tb01078Dtalt { get; set; }
        public string Tb01078Opalt { get; set; }
        public string Tb01078Codigo { get; set; }
        public string Tb01078Nome { get; set; }
        public string Tb01078Situacao { get; set; }
        public string Tb01078Impostos { get; set; }
        public string Tb01078Natureza { get; set; }
        public string Tb01078Natureza2 { get; set; }
        public string Tb01078Cicms { get; set; }
        public string Tb01078Cst { get; set; }
        public decimal? Tb01078Icms { get; set; }
        public string Tb01078Cipi { get; set; }
        public string Tb01078Cstipi { get; set; }
        public decimal? Tb01078Ipi { get; set; }
        public string Tb01078Cpis { get; set; }
        public string Tb01078Cstpis { get; set; }
        public decimal? Tb01078Aliqpis { get; set; }
        public string Tb01078Ccofins { get; set; }
        public string Tb01078Cstcofins { get; set; }
        public decimal? Tb01078Aliqcofins { get; set; }
        public string Tb01078Bonif { get; set; }
        public string Tb01078Npreco { get; set; }
        public string Tb01078Tipoestoque { get; set; }
        public string Tb01078Ccst { get; set; }
        public string Tb01078Ccstpis { get; set; }
        public string Tb01078Ccstcofins { get; set; }
        public string Tb01078Ccstipi { get; set; }
        public string Tb01078Cicmsst { get; set; }
        public decimal? Tb01078Icmsst { get; set; }
        public string Tb01078Cmva { get; set; }
        public decimal? Tb01078Mva { get; set; }
        public string Tb01078Codcen { get; set; }
        public string Tb01078Codsub { get; set; }
        public string Tb01078Plancon { get; set; }
        public string Tb01078Obsnota { get; set; }
        public string Tb01078Cbasered { get; set; }
        public decimal? Tb01078Basered { get; set; }
        public string Tb01078Nestoque { get; set; }

        public virtual ICollection<Tb02002> Tb02002 { get; set; }
        public virtual ICollection<Tb02003> Tb02003 { get; set; }
        public virtual ICollection<Tb02030> Tb02030 { get; set; }
        public virtual ICollection<Tb02031> Tb02031 { get; set; }
        public virtual ICollection<Tb02063> Tb02063 { get; set; }
        public virtual ICollection<Tb02073> Tb02073 { get; set; }
        public virtual ICollection<Tb02074> Tb02074 { get; set; }
    }
}