using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb03007
    {
        public DateTime? Tb03007Dtcad { get; set; }
        public string Tb03007Opcad { get; set; }
        public DateTime? Tb03007Dtalt { get; set; }
        public string Tb03007Opalt { get; set; }
        public string Tb03007Cademp { get; set; }
        public string Tb03007Codigo { get; set; }
        public DateTime? Tb03007Data { get; set; }
        public DateTime? Tb03007Data2 { get; set; }
        public string Tb03007Nome { get; set; }
        public decimal? Tb03007Vlrapura { get; set; }
        public decimal? Tb03007Vlrinicio { get; set; }
        public decimal? Tb03007Vlrcaixa { get; set; }
        public string Tb03007Enviado { get; set; }
        public string Tb03007Numserie { get; set; }
        public string Tb03007Obs { get; set; }
        public string Tb03007Turno { get; set; }

        public virtual Tb01007 Tb03007CadempNavigation { get; set; }
        public virtual Tb03008 Tb03007TurnoNavigation { get; set; }
    }
}