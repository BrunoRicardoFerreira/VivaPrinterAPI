using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02203
    {
        public string Tb02203Codigo { get; set; }
        public DateTime? Tb02203Dtcad { get; set; }
        public string Tb02203Opcad { get; set; }
        public DateTime? Tb02203Dtalt { get; set; }
        public string Tb02203Opalt { get; set; }
        public string Tb02203Descricao { get; set; }
        public string Tb02203Produto { get; set; }
        public decimal? Tb02203Basecalculo { get; set; }
        public decimal? Tb02203Aliquota { get; set; }
        public decimal? Tb02203Valoricms { get; set; }
        public decimal? Tb02203Outrosvalores { get; set; }
        public string Tb02203Compra { get; set; }
        public string Tb02203CodigoReg195 { get; set; }

        public virtual Tb02073 Tb02203CompraNavigation { get; set; }
    }
}