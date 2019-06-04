using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01102
    {
        public Tb01102()
        {
            Tb04005 = new HashSet<Tb04005>();
            Tb04014 = new HashSet<Tb04014>();
            Tb04050 = new HashSet<Tb04050>();
        }

        public DateTime? Tb01102Dtcad { get; set; }
        public string Tb01102Opcad { get; set; }
        public DateTime? Tb01102Dtalt { get; set; }
        public string Tb01102Opalt { get; set; }
        public string Tb01102Codigo { get; set; }
        public string Tb01102Nome { get; set; }
        public string Tb01102Inicial { get; set; }
        public string Tb01102Baixa { get; set; }
        public string Tb01102Alterar { get; set; }
        public string Tb01102Excluir { get; set; }
        public string Tb01102Renegocia { get; set; }
        public string Tb01102Compra { get; set; }
        public string Tb01102Despesa { get; set; }
        public string Tb01102Servico { get; set; }
        public string Tb01102Frete { get; set; }
        public string Tb01102Situacao { get; set; }
        public string Tb01102Color { get; set; }
        public string Tb01102Color2 { get; set; }
        public decimal? Tb01102Valor1 { get; set; }
        public decimal? Tb01102Valor2 { get; set; }

        public virtual ICollection<Tb04005> Tb04005 { get; set; }
        public virtual ICollection<Tb04014> Tb04014 { get; set; }
        public virtual ICollection<Tb04050> Tb04050 { get; set; }
    }
}