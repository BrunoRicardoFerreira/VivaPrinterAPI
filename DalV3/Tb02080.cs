using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02080
    {
        public DateTime? Tb02080Dtcad { get; set; }
        public string Tb02080Opcad { get; set; }
        public DateTime? Tb02080Dtalt { get; set; }
        public string Tb02080Opalt { get; set; }
        public string Tb02080Codigo { get; set; }
        public decimal? Tb02080Custo { get; set; }
        public decimal? Tb02080Perdesc { get; set; }
        public string Tb02080Produto { get; set; }
        public decimal? Tb02080Prunit { get; set; }
        public decimal? Tb02080Qtprod { get; set; }
        public decimal? Tb02080Qtprodb { get; set; }
        public string Tb02080Situacao { get; set; }
        public decimal? Tb02080Totvalor { get; set; }
        public decimal? Tb02080Totvalorb { get; set; }
        public decimal? Tb02080Vlrdesc { get; set; }
        public decimal? Tb02080Vlrdescb { get; set; }
        public decimal? Tb02080Icms { get; set; }
        public decimal? Tb02080Vlricms { get; set; }
        public decimal? Tb02080Vlricmsb { get; set; }
        public string Tb02080Natureza { get; set; }
        public decimal? Tb02080Percipi { get; set; }
        public decimal? Tb02080Vlripi { get; set; }
        public decimal? Tb02080Vlripib { get; set; }
        public decimal? Tb02080Percst { get; set; }
        public decimal? Tb02080Vlrst { get; set; }
        public decimal? Tb02080Vlrstb { get; set; }
        public decimal? Tb02080Basered { get; set; }
        public decimal? Tb02080Baseicms { get; set; }
        public decimal? Tb02080Baseicmsb { get; set; }
        public decimal? Tb02080Basest { get; set; }
        public decimal? Tb02080Basestb { get; set; }

        public virtual Tb02079 Tb02080CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02080ProdutoNavigation { get; set; }
    }
}