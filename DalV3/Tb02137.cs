using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02137
    {
        public int Tb02137Codigo { get; set; }
        public int Tb02137Id { get; set; }
        public string Tb02137Opcad { get; set; }
        public DateTime? Tb02137Data { get; set; }
        public string Tb02137Obs { get; set; }
        public string Tb02137Respondido { get; set; }
        public string Tb02137Opatual { get; set; }
        public DateTime? Tb02137Previsao { get; set; }
        public string Tb02137Status { get; set; }

        public virtual Tb02102 Tb02137CodigoNavigation { get; set; }
        public virtual Tb01044 Tb02137StatusNavigation { get; set; }
    }
}