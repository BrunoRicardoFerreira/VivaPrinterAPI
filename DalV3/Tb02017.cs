using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02017
    {
        public DateTime? Tb02017Dtcad { get; set; }
        public string Tb02017Opcad { get; set; }
        public DateTime? Tb02017Dtalt { get; set; }
        public string Tb02017Opalt { get; set; }
        public string Tb02017Codigo { get; set; }
        public decimal? Tb02017Custo { get; set; }
        public decimal? Tb02017Perdesc { get; set; }
        public string Tb02017Produto { get; set; }
        public decimal? Tb02017Prunit { get; set; }
        public decimal? Tb02017Qtprod { get; set; }
        public decimal? Tb02017Qtprodb { get; set; }
        public decimal? Tb02017Qtprode { get; set; }
        public string Tb02017Situacao { get; set; }
        public decimal? Tb02017Totvalor { get; set; }
        public decimal? Tb02017Totvalorb { get; set; }
        public decimal? Tb02017Totvalore { get; set; }
        public decimal? Tb02017Vlrdesc { get; set; }
        public decimal? Tb02017Vlrdescb { get; set; }
        public decimal? Tb02017Icms { get; set; }
        public decimal? Tb02017Vlricms { get; set; }
        public decimal? Tb02017Vlricmsb { get; set; }
        public string Tb02017Natureza { get; set; }
        public decimal? Tb02017Percipi { get; set; }
        public decimal? Tb02017Vlripi { get; set; }
        public decimal? Tb02017Vlripib { get; set; }
        public decimal? Tb02017Percst { get; set; }
        public decimal? Tb02017Vlrst { get; set; }
        public decimal? Tb02017Vlrstb { get; set; }
        public string Tb02017Tipoestorno { get; set; }
        public string Tb02017Produto2 { get; set; }
        public DateTime Tb02017Data { get; set; }
        public string Tb02017Pedcom { get; set; }
        public string Tb02017Codigo2 { get; set; }
        public string Tb02017Numdev { get; set; }
        public decimal? Tb02017Qtadd { get; set; }
        public string Tb02017Ajuste { get; set; }
        public string Tb02017Numcredito { get; set; }
        public string Tb02017Estnormal { get; set; }
        public string Tb02017Ntfisc { get; set; }
        public string Tb02017Obs { get; set; }

        public virtual Tb02015 Tb02017CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02017ProdutoNavigation { get; set; }
    }
}