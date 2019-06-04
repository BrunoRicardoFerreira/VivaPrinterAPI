using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02052
    {
        public DateTime? Tb02052Dtcad { get; set; }
        public string Tb02052Opcad { get; set; }
        public DateTime? Tb02052Dtalt { get; set; }
        public string Tb02052Opalt { get; set; }
        public string Tb02052Codigo { get; set; }
        public decimal? Tb02052Custo { get; set; }
        public decimal? Tb02052Perdesc { get; set; }
        public string Tb02052Produto { get; set; }
        public decimal? Tb02052Prunit { get; set; }
        public decimal? Tb02052Qtprod { get; set; }
        public decimal? Tb02052Qtprodb { get; set; }
        public decimal? Tb02052Qtprode { get; set; }
        public string Tb02052Situacao { get; set; }
        public decimal? Tb02052Totvalor { get; set; }
        public decimal? Tb02052Totvalorb { get; set; }
        public decimal? Tb02052Totvalore { get; set; }
        public decimal? Tb02052Vlrdesc { get; set; }
        public decimal? Tb02052Vlrdescb { get; set; }
        public decimal? Tb02052Icms { get; set; }
        public decimal? Tb02052Vlricms { get; set; }
        public decimal? Tb02052Vlricmsb { get; set; }
        public string Tb02052Natureza { get; set; }
        public decimal? Tb02052Percipi { get; set; }
        public decimal? Tb02052Vlripi { get; set; }
        public decimal? Tb02052Vlripib { get; set; }
        public decimal? Tb02052Percst { get; set; }
        public decimal? Tb02052Vlrst { get; set; }
        public decimal? Tb02052Vlrstb { get; set; }
        public decimal? Tb02052Qtprodv { get; set; }

        public virtual Tb02050 Tb02052CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02052ProdutoNavigation { get; set; }
    }
}