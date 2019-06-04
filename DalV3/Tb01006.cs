using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01006
    {
        public Tb01006()
        {
            Tb01008Tb01008Vendedor2Navigation = new HashSet<Tb01008>();
            Tb01008Tb01008VendedorNavigation = new HashSet<Tb01008>();
            Tb01039 = new HashSet<Tb01039>();
            Tb01055 = new HashSet<Tb01055>();
            Tb01080 = new HashSet<Tb01080>();
            Tb02111 = new HashSet<Tb02111>();
            Tb02112 = new HashSet<Tb02112>();
            Tb02118 = new HashSet<Tb02118>();
            Tb02122 = new HashSet<Tb02122>();
            Tb02155 = new HashSet<Tb02155>();
            Tb02166 = new HashSet<Tb02166>();
            Tb04010 = new HashSet<Tb04010>();
        }

        public DateTime? Tb01006Dtcad { get; set; }
        public string Tb01006Opcad { get; set; }
        public DateTime? Tb01006Dtalt { get; set; }
        public string Tb01006Opalt { get; set; }
        public string Tb01006Ag { get; set; }
        public string Tb01006Banco { get; set; }
        public string Tb01006Classe { get; set; }
        public int? Tb01006Clientes { get; set; }
        public string Tb01006Codigo { get; set; }
        public decimal? Tb01006Comissao { get; set; }
        public string Tb01006Conta { get; set; }
        public string Tb01006Cpf { get; set; }
        public decimal? Tb01006Ctrec { get; set; }
        public decimal? Tb01006Ctaberto { get; set; }
        public DateTime? Tb01006Dtaniv { get; set; }
        public string Tb01006Ident { get; set; }
        public string Tb01006Nome { get; set; }
        public string Tb01006Obs { get; set; }
        public int? Tb01006Produtos { get; set; }
        public string Tb01006Situacao { get; set; }
        public int? Tb01006Vendas { get; set; }
        public decimal? Tb01006Vlrvendas { get; set; }
        public DateTime? Tb01006Ultvendas { get; set; }
        public string Tb01006Gerente { get; set; }

        public virtual ICollection<Tb01008> Tb01008Tb01008Vendedor2Navigation { get; set; }
        public virtual ICollection<Tb01008> Tb01008Tb01008VendedorNavigation { get; set; }
        public virtual ICollection<Tb01039> Tb01039 { get; set; }
        public virtual ICollection<Tb01055> Tb01055 { get; set; }
        public virtual ICollection<Tb01080> Tb01080 { get; set; }
        public virtual ICollection<Tb02111> Tb02111 { get; set; }
        public virtual ICollection<Tb02112> Tb02112 { get; set; }
        public virtual ICollection<Tb02118> Tb02118 { get; set; }
        public virtual ICollection<Tb02122> Tb02122 { get; set; }
        public virtual ICollection<Tb02155> Tb02155 { get; set; }
        public virtual ICollection<Tb02166> Tb02166 { get; set; }
        public virtual ICollection<Tb04010> Tb04010 { get; set; }
    }
}