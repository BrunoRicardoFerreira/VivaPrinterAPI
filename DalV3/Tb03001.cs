using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb03001
    {
        public DateTime? Tb03001Dtcad { get; set; }
        public string Tb03001Opcad { get; set; }
        public DateTime? Tb03001Dtalt { get; set; }
        public string Tb03001Opalt { get; set; }
        public string Tb03001Cademp { get; set; }
        public string Tb03001Codigo { get; set; }
        public DateTime? Tb03001Data { get; set; }
        public DateTime? Tb03001Data2 { get; set; }
        public string Tb03001Nome { get; set; }
        public decimal? Tb03001Vlrapura { get; set; }
        public decimal? Tb03001Vlrinicio { get; set; }
        public decimal? Tb03001Vlrcaixa { get; set; }
        public string Tb03001Enviado { get; set; }
        public string Tb03001Numserie { get; set; }
        public string Tb03001Obs { get; set; }
        public string Tb03001Turno { get; set; }
        public string Tb03001Cupom { get; set; }
        public string Tb03001Bandeira { get; set; }

        public virtual Tb01007 Tb03001CadempNavigation { get; set; }
        public virtual Tb03008 Tb03001TurnoNavigation { get; set; }
    }
}