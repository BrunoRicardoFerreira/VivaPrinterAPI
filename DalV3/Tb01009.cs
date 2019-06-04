using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01009
    {
        public Tb01009()
        {
            Tb01001 = new HashSet<Tb01001>();
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
            Tb02230 = new HashSet<Tb02230>();
            Tb04014 = new HashSet<Tb04014>();
            Tb04036 = new HashSet<Tb04036>();
        }

        public DateTime? Tb01009Dtcad { get; set; }
        public string Tb01009Opcad { get; set; }
        public DateTime? Tb01009Dtalt { get; set; }
        public string Tb01009Opalt { get; set; }
        public string Tb01009Cnpj { get; set; }
        public string Tb01009Codigo { get; set; }
        public string Tb01009Compra { get; set; }
        public string Tb01009Despesa { get; set; }
        public int? Tb01009Diasentrega { get; set; }
        public string Tb01009Fantasia { get; set; }
        public int? Tb01009Frete { get; set; }
        public string Tb01009Inativo { get; set; }
        public string Tb01009Inscest { get; set; }
        public string Tb01009Inscmun { get; set; }
        public string Tb01009Nome { get; set; }
        public string Tb01009Obs { get; set; }
        public string Tb01009Codcen { get; set; }
        public string Tb01009Codsub { get; set; }
        public string Tb01009Plancon { get; set; }
        public decimal? Tb01009Vlrfrete { get; set; }
        public string Tb01009Pessoa { get; set; }
        public string Tb01009Cpf { get; set; }
        public string Tb01009Ident { get; set; }

        public virtual Tb04004 Tb01009CodcenNavigation { get; set; }
        public virtual Tb04005 Tb01009CodsubNavigation { get; set; }
        public virtual Tb04006 Tb01009PlanconNavigation { get; set; }
        public virtual ICollection<Tb01001> Tb01001 { get; set; }
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
        public virtual ICollection<Tb02230> Tb02230 { get; set; }
        public virtual ICollection<Tb04014> Tb04014 { get; set; }
        public virtual ICollection<Tb04036> Tb04036 { get; set; }
    }
}