using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02214
    {
        public DateTime? Tb02214Dtcad { get; set; }
        public string Tb02214Opcad { get; set; }
        public DateTime? Tb02214Dtalt { get; set; }
        public string Tb02214Opalt { get; set; }
        public string Tb02214Numos { get; set; }
        public string Tb02214Codtec { get; set; }
        public DateTime? Tb02214Data { get; set; }
        public string Tb02214Motivo { get; set; }
        public decimal? Tb02214Pontuacao { get; set; }
        public string Tb02214Debitocredtio { get; set; }
        public string Tb02214Os { get; set; }

        public virtual Tb01024 Tb02214CodtecNavigation { get; set; }
    }
}