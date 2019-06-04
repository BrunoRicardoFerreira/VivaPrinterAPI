using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02196
    {
        public DateTime? Tb02196Dtcad { get; set; }
        public string Tb02196Opcad { get; set; }
        public DateTime? Tb02196Dtalt { get; set; }
        public string Tb02196Opalt { get; set; }
        public string Tb02196Codigo { get; set; }
        public string Tb02196Remessa { get; set; }
        public string Tb02196Codserv { get; set; }
        public int? Tb02196Qtprod { get; set; }
        public int? Tb02196Qtprodb { get; set; }
        public int? Tb02196Qtperda { get; set; }
        public int? Tb02196Qtperdab { get; set; }
        public string Tb02196Reembolso { get; set; }
        public string Tb02196Codtec { get; set; }
        public int? Tb02196Medidor { get; set; }
        public string Tb02196Requisicao { get; set; }
        public string Tb02196Obs { get; set; }
        public int? Tb02196Credcopias { get; set; }
        public string Tb02196Codequip { get; set; }
        public int? Tb02196Credcopiasb { get; set; }
        public int? Tb02196Medanterior { get; set; }
        public string Tb02196Banner { get; set; }

        public virtual Tb01093 Tb02196CodequipNavigation { get; set; }
        public virtual Tb01094 Tb02196CodservNavigation { get; set; }
        public virtual Tb01024 Tb02196CodtecNavigation { get; set; }
        public virtual Tb02195 Tb02196RemessaNavigation { get; set; }
    }
}