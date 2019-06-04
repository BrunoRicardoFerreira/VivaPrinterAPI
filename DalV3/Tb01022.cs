using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01022
    {
        public Tb01022()
        {
            Tb01039 = new HashSet<Tb01039>();
            Tb01046 = new HashSet<Tb01046>();
            Tb01055 = new HashSet<Tb01055>();
            Tb01080 = new HashSet<Tb01080>();
            Tb02112 = new HashSet<Tb02112>();
            Tb02122 = new HashSet<Tb02122>();
        }

        public DateTime? Tb01022Dtcad { get; set; }
        public string Tb01022Opcad { get; set; }
        public DateTime? Tb01022Dtalt { get; set; }
        public string Tb01022Opalt { get; set; }
        public string Tb01022Codigo { get; set; }
        public string Tb01022Nome { get; set; }
        public string Tb01022Situacao { get; set; }
        public string Tb01022Impostos { get; set; }
        public decimal? Tb01022Icms { get; set; }
        public decimal? Tb01022Icmsst { get; set; }
        public decimal? Tb01022Ipi { get; set; }
        public decimal? Tb01022Aliqpis { get; set; }
        public decimal? Tb01022Aliqcofins { get; set; }
        public decimal? Tb01022Aliqcsll { get; set; }
        public decimal? Tb01022Mva { get; set; }
        public decimal? Tb01022Aliqimpfat { get; set; }
        public decimal? Tb01022Basered { get; set; }
        public decimal? Tb01022Ir { get; set; }
        public string Tb01022Cicms { get; set; }
        public string Tb01022Cicmsst { get; set; }
        public string Tb01022Cipi { get; set; }
        public string Tb01022Caliqpis { get; set; }
        public string Tb01022Caliqcofins { get; set; }
        public string Tb01022Caliqcsll { get; set; }
        public string Tb01022Cmva { get; set; }
        public string Tb01022Caliqimpfat { get; set; }
        public string Tb01022Cbasered { get; set; }
        public string Tb01022Cir { get; set; }
        public string Tb01022Revenda { get; set; }
        public decimal? Tb01022Markup { get; set; }
        public string Tb01022Formapreco { get; set; }
        public string Tb01022Cmarkup { get; set; }
        public string Tb01022Natureza { get; set; }
        public string Tb01022Natureza2 { get; set; }
        public string Tb01022Cst { get; set; }
        public string Tb01022Obsnota { get; set; }
        public decimal? Tb01022Acres { get; set; }
        public string Tb01022Cstpis { get; set; }
        public string Tb01022Cstcofins { get; set; }
        public string Tb01022Cstipi { get; set; }
        public string Tb01022Ccst { get; set; }
        public string Tb01022Ccstpis { get; set; }
        public string Tb01022Ccstcofins { get; set; }
        public string Tb01022Ccstipi { get; set; }
        public string Tb01022Tipooper { get; set; }
        public string Tb01022Codcen { get; set; }
        public string Tb01022Codsub { get; set; }
        public string Tb01022Plancon { get; set; }
        public string Tb01022Tipoconsumo { get; set; }
        public string Tb01022Tipoestoque { get; set; }
        public string Tb01022Bonif { get; set; }
        public string Tb01022Nestoque { get; set; }
        public string Tb01022Dataconv { get; set; }
        public string Tb01022Serie { get; set; }
        public string Tb01022Codemp { get; set; }
        public string Tb01022Nomeemp { get; set; }
        public string Tb01022Obrserie { get; set; }
        public string Tb01022Abrirkit { get; set; }
        public string Tb01022Remessa { get; set; }
        public string Tb01022Autostatus { get; set; }
        public string Tb01022Contrato { get; set; }
        public string Tb01022Sitedepto { get; set; }
        public string Tb01022Outros { get; set; }
        public string Tb01022Toner { get; set; }
        public string Tb01022Pecas { get; set; }
        public string Tb01022Papel { get; set; }
        public string Tb01022Equipamento { get; set; }
        public string Tb01022Simplesfat { get; set; }
        public string Tb01022Plancon2 { get; set; }
        public string Tb01022Retorno { get; set; }
        public decimal? Tb01022Fcp { get; set; }
        public decimal? Tb01022Fcpst { get; set; }
        public string Tb01022Cfcp { get; set; }
        public string Tb01022Cfcpst { get; set; }
        public int? Tb01022Indpres { get; set; }
        public string Tb01022Descdataservice { get; set; }

        public virtual Tb01092 Tb01092 { get; set; }
        public virtual ICollection<Tb01039> Tb01039 { get; set; }
        public virtual ICollection<Tb01046> Tb01046 { get; set; }
        public virtual ICollection<Tb01055> Tb01055 { get; set; }
        public virtual ICollection<Tb01080> Tb01080 { get; set; }
        public virtual ICollection<Tb02112> Tb02112 { get; set; }
        public virtual ICollection<Tb02122> Tb02122 { get; set; }
    }
}