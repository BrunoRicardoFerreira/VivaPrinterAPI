using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02054
    {
        public string Tb02054Produto { get; set; }
        public string Tb02054Numserie { get; set; }
        public DateTime? Tb02054Dtvalidade { get; set; }
        public decimal? Tb02054Qtprod { get; set; }
        public decimal? Tb02054Qtprods { get; set; }
        public string Tb02054Codemp { get; set; }
        public decimal? Tb02054Rma { get; set; }
        public decimal? Tb02054Rmat { get; set; }
        public decimal? Tb02054Rmar { get; set; }
        public decimal? Tb02054Rmag { get; set; }
        public string Tb02054Imob { get; set; }
        public decimal? Tb02054Custo { get; set; }
        public string Tb02054Codfor { get; set; }
        public string Tb02054Nomefor { get; set; }
        public string Tb02054Obs { get; set; }
        public string Tb02054Locser { get; set; }
        public string Tb02054Tipocon { get; set; }
        public string Tb02054Locpprod { get; set; }
        public string Tb02054Pat { get; set; }
        public string Tb02054Status { get; set; }
        public DateTime? Tb02054Dtfabricacao { get; set; }
        public decimal? Tb02054Indprec { get; set; }
        public int? Tb02054Mesprec { get; set; }

        public virtual Tb01096 Tb02054StatusNavigation { get; set; }
    }
}