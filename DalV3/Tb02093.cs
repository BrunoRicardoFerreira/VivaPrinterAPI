using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02093
    {
        public Tb02093()
        {
            Tb02053 = new HashSet<Tb02053>();
        }

        public string Tb02093Codigo { get; set; }
        public DateTime? Tb02093Dtreserva { get; set; }
        public int? Tb02093Ordem { get; set; }
        public decimal? Tb02093Qtde { get; set; }
        public decimal? Tb02093Vlrnota { get; set; }
        public decimal? Tb02093Qtde2 { get; set; }
        public decimal? Tb02093Vlrnota2 { get; set; }
        public string Tb02093Opreserva { get; set; }
        public DateTime? Tb02093Dtalt { get; set; }
        public string Tb02093Codcli { get; set; }
        public string Tb02093Codemp { get; set; }
        public int Tb02093Operacao { get; set; }

        public virtual ICollection<Tb02053> Tb02053 { get; set; }
    }
}