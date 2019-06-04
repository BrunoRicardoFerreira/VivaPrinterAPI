using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01011
    {
        public Tb01011()
        {
            Tb02002 = new HashSet<Tb02002>();
            Tb02005 = new HashSet<Tb02005>();
            Tb02007 = new HashSet<Tb02007>();
            Tb02009 = new HashSet<Tb02009>();
            Tb02011 = new HashSet<Tb02011>();
            Tb02013 = new HashSet<Tb02013>();
            Tb02015 = new HashSet<Tb02015>();
            Tb02026 = new HashSet<Tb02026>();
            Tb02030 = new HashSet<Tb02030>();
            Tb02048 = new HashSet<Tb02048>();
            Tb02050 = new HashSet<Tb02050>();
            Tb02057 = new HashSet<Tb02057>();
            Tb02059 = new HashSet<Tb02059>();
            Tb02073 = new HashSet<Tb02073>();
            Tb02075 = new HashSet<Tb02075>();
            Tb02077 = new HashSet<Tb02077>();
            Tb02079 = new HashSet<Tb02079>();
            Tb02087 = new HashSet<Tb02087>();
            Tb02088 = new HashSet<Tb02088>();
            Tb02091 = new HashSet<Tb02091>();
            Tb02100 = new HashSet<Tb02100>();
            Tb02118 = new HashSet<Tb02118>();
            Tb02144 = new HashSet<Tb02144>();
            Tb02157 = new HashSet<Tb02157>();
            Tb02166 = new HashSet<Tb02166>();
            Tb02227 = new HashSet<Tb02227>();
        }

        public DateTime? Tb01011Dtcad { get; set; }
        public string Tb01011Opcad { get; set; }
        public DateTime? Tb01011Dtalt { get; set; }
        public string Tb01011Opalt { get; set; }
        public string Tb01011Codnat { get; set; }
        public string Tb01011Nome { get; set; }
        public string Tb01011Situacao { get; set; }
        public string Tb01011Codigo { get; set; }
        public string Tb01011Bonif { get; set; }
        public string Tb01011Operacao { get; set; }
        public string Tb01011Icmscred { get; set; }
        public string Tb01011Ipicred { get; set; }
        public string Tb01011Piscred { get; set; }
        public string Tb01011Cofcred { get; set; }
        public string Tb01011Icmsdeb { get; set; }
        public string Tb01011Ipideb { get; set; }
        public string Tb01011Pisdeb { get; set; }
        public string Tb01011Cofdeb { get; set; }
        public string Tb01011Obs { get; set; }
        public string Tb01011Tb02002 { get; set; }
        public string Tb01011Tb02005 { get; set; }
        public string Tb01011Tb02007 { get; set; }
        public string Tb01011Tb02009 { get; set; }
        public string Tb01011Tb02011 { get; set; }
        public string Tb01011Tb02013 { get; set; }
        public string Tb01011Tb02015 { get; set; }
        public string Tb01011Tb02015e { get; set; }
        public string Tb01011Tb02021 { get; set; }
        public string Tb01011Tb02026 { get; set; }
        public string Tb01011Tb02057 { get; set; }
        public string Tb01011Tb02050 { get; set; }
        public string Tb01011Tb02059 { get; set; }
        public string Tb01011Industrializacao { get; set; }
        public string Tb01011Npreco { get; set; }
        public string Tb01011Tb02118 { get; set; }
        public string Tb01011Nestoque { get; set; }
        public string Tb01011Imob { get; set; }
        public string Tb01011Sped { get; set; }
        public string Tb01011Spedcontr { get; set; }
        public string Tb01011Cicms { get; set; }
        public string Tb01011Cst { get; set; }
        public decimal? Tb01011Icms { get; set; }
        public string Tb01011Cpis { get; set; }
        public string Tb01011Cstpis { get; set; }
        public decimal? Tb01011Pis { get; set; }
        public string Tb01011Ccofins { get; set; }
        public string Tb01011Cstcofins { get; set; }
        public decimal? Tb01011Cofins { get; set; }
        public string Tb01011Cipi { get; set; }
        public string Tb01011Cstipi { get; set; }
        public decimal? Tb01011Ipi { get; set; }
        public string Tb01011Incfrete { get; set; }
        public string Tb01011Incoutdesp { get; set; }
        public string Tb01011Incipi { get; set; }
        public string Tb01011Incst { get; set; }
        public string Tb01011Calcir { get; set; }
        public string Tb01011Calccsll { get; set; }
        public string Tb01011Remst { get; set; }
        public string Tb01011Transparencia { get; set; }
        public string Tb01011Estorno { get; set; }
        public string Tb01011Relpiscofins { get; set; }
        public string Tb01011Plansped { get; set; }
        public string Tb01011Plancon { get; set; }

        public virtual Tb04006 Tb01011PlanconNavigation { get; set; }
        public virtual ICollection<Tb02002> Tb02002 { get; set; }
        public virtual ICollection<Tb02005> Tb02005 { get; set; }
        public virtual ICollection<Tb02007> Tb02007 { get; set; }
        public virtual ICollection<Tb02009> Tb02009 { get; set; }
        public virtual ICollection<Tb02011> Tb02011 { get; set; }
        public virtual ICollection<Tb02013> Tb02013 { get; set; }
        public virtual ICollection<Tb02015> Tb02015 { get; set; }
        public virtual ICollection<Tb02026> Tb02026 { get; set; }
        public virtual ICollection<Tb02030> Tb02030 { get; set; }
        public virtual ICollection<Tb02048> Tb02048 { get; set; }
        public virtual ICollection<Tb02050> Tb02050 { get; set; }
        public virtual ICollection<Tb02057> Tb02057 { get; set; }
        public virtual ICollection<Tb02059> Tb02059 { get; set; }
        public virtual ICollection<Tb02073> Tb02073 { get; set; }
        public virtual ICollection<Tb02075> Tb02075 { get; set; }
        public virtual ICollection<Tb02077> Tb02077 { get; set; }
        public virtual ICollection<Tb02079> Tb02079 { get; set; }
        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb02088> Tb02088 { get; set; }
        public virtual ICollection<Tb02091> Tb02091 { get; set; }
        public virtual ICollection<Tb02100> Tb02100 { get; set; }
        public virtual ICollection<Tb02118> Tb02118 { get; set; }
        public virtual ICollection<Tb02144> Tb02144 { get; set; }
        public virtual ICollection<Tb02157> Tb02157 { get; set; }
        public virtual ICollection<Tb02166> Tb02166 { get; set; }
        public virtual ICollection<Tb02227> Tb02227 { get; set; }
    }
}