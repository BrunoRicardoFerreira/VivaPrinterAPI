using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02053
    {
        public DateTime? Tb02053Dtcad { get; set; }
        public string Tb02053Opcad { get; set; }
        public DateTime? Tb02053Dtalt { get; set; }
        public string Tb02053Opalt { get; set; }
        public string Tb02053Codigo { get; set; }
        public string Tb02053Produto { get; set; }
        public decimal? Tb02053Qtprod { get; set; }
        public decimal? Tb02053Qtprodb { get; set; }
        public decimal? Tb02053Prunit { get; set; }
        public decimal? Tb02053Totvalor { get; set; }
        public decimal? Tb02053Totvalorb { get; set; }
        public decimal? Tb02053Qtprodd { get; set; }
        public decimal? Tb02053Totvalord { get; set; }
        public decimal? Tb02053Qtproddb { get; set; }
        public decimal? Tb02053Totvalordb { get; set; }
        public DateTime? Tb02053Dtdisp { get; set; }
        public string Tb02053Compra { get; set; }
        public string Tb02053Ntfisc { get; set; }
        public string Tb02053Codcli { get; set; }
        public string Tb02053Codemp { get; set; }
        public int Tb02053Operacao { get; set; }

        public virtual Tb02093 Tb02053Navigation { get; set; }
    }
}