using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02167
    {
        public Tb02167()
        {
            Tb02168 = new HashSet<Tb02168>();
        }

        public DateTime? Tb02167Dtcad { get; set; }
        public string Tb02167Opcad { get; set; }
        public DateTime? Tb02167Dtalt { get; set; }
        public string Tb02167Opalt { get; set; }
        public string Tb02167Codigo { get; set; }
        public decimal? Tb02167Custo { get; set; }
        public decimal? Tb02167Perdesc { get; set; }
        public string Tb02167Produto { get; set; }
        public decimal? Tb02167Prunit { get; set; }
        public decimal? Tb02167Qtprod { get; set; }
        public decimal? Tb02167Qtprodb { get; set; }
        public string Tb02167Situacao { get; set; }
        public decimal? Tb02167Totvalor { get; set; }
        public decimal? Tb02167Totvalorb { get; set; }
        public decimal? Tb02167Vlrdesc { get; set; }
        public decimal? Tb02167Vlrdescb { get; set; }
        public decimal? Tb02167Icms { get; set; }
        public decimal? Tb02167Vlricms { get; set; }
        public decimal? Tb02167Vlricmsb { get; set; }
        public string Tb02167Natureza { get; set; }
        public decimal? Tb02167Percipi { get; set; }
        public decimal? Tb02167Vlripi { get; set; }
        public decimal? Tb02167Vlripib { get; set; }
        public decimal? Tb02167Percst { get; set; }
        public decimal? Tb02167Vlrst { get; set; }
        public decimal? Tb02167Vlrstb { get; set; }
        public decimal? Tb02167Basered { get; set; }
        public decimal? Tb02167Baseicms { get; set; }
        public decimal? Tb02167Baseicmsb { get; set; }
        public decimal? Tb02167Basest { get; set; }
        public decimal? Tb02167Basestb { get; set; }

        public virtual Tb02166 Tb02167CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02167ProdutoNavigation { get; set; }
        public virtual ICollection<Tb02168> Tb02168 { get; set; }
    }
}