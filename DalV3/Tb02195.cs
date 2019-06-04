using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02195
    {
        public Tb02195()
        {
            Tb02196 = new HashSet<Tb02196>();
        }

        public DateTime? Tb02195Dtcad { get; set; }
        public string Tb02195Opcad { get; set; }
        public DateTime? Tb02195Dtalt { get; set; }
        public string Tb02195Opalt { get; set; }
        public string Tb02195Codigo { get; set; }
        public string Tb02195Os { get; set; }
        public string Tb02195Codequip { get; set; }
        public string Tb02195Setor { get; set; }
        public DateTime? Tb02195Data { get; set; }
        public int? Tb02195Medidor { get; set; }
        public int? Tb02195Qtprod { get; set; }
        public int? Tb02195Qtprodperda { get; set; }
        public int? Tb02195Qtprodsaldo { get; set; }
        public string Tb02195Requisicao { get; set; }
        public string Tb02195Faturado { get; set; }
        public string Tb02195Pedido { get; set; }
        public string Tb02195Obs { get; set; }
        public string Tb02195Nome { get; set; }
        public string Tb02195Codemp { get; set; }
        public string Tb02195Situacao { get; set; }
        public int? Tb02195Credcopias { get; set; }

        public virtual Tb01007 Tb02195CodempNavigation { get; set; }
        public virtual Tb01093 Tb02195CodequipNavigation { get; set; }
        public virtual Tb02193 Tb02195OsNavigation { get; set; }
        public virtual Tb01105 Tb02195SetorNavigation { get; set; }
        public virtual ICollection<Tb02196> Tb02196 { get; set; }
    }
}