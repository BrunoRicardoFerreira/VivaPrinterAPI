using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02201
    {
        public string Tb02201Codigo { get; set; }
        public DateTime? Tb02201Dtcad { get; set; }
        public string Tb02201Opcad { get; set; }
        public DateTime? Tb02201Dtalt { get; set; }
        public string Tb02201Opalt { get; set; }
        public string Tb02201Descricao { get; set; }
        public string Tb02201Produto { get; set; }
        public decimal? Tb02201Basecalculo { get; set; }
        public decimal? Tb02201Aliquota { get; set; }
        public decimal? Tb02201Valoricms { get; set; }
        public decimal? Tb02201Outrosvalores { get; set; }
        public string Tb02201Compra { get; set; }
        public string Tb02201CodigoReg195 { get; set; }

        public virtual Tb02002 Tb02201CompraNavigation { get; set; }
    }
}