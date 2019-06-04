using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02065
    {
        public int Tb02065Cotacao { get; set; }
        public string Tb02065Produto { get; set; }
        public string Tb02065Forn { get; set; }
        public string Tb02065Compra { get; set; }
        public string Tb02065Ntfisc { get; set; }
        public string Tb02065Nome { get; set; }
        public string Tb02065Fone { get; set; }
        public string Tb02065Email { get; set; }
        public decimal? Tb02065Prunit { get; set; }
        public DateTime? Tb02065Data { get; set; }
        public string Tb02065Selec { get; set; }
        public decimal? Tb02065Vlripi { get; set; }

        public virtual Tb02063 Tb02065CotacaoNavigation { get; set; }
        public virtual Tb01001 Tb02065FornNavigation { get; set; }
        public virtual Tb01010 Tb02065ProdutoNavigation { get; set; }
    }
}