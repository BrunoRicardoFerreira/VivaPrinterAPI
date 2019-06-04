using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02193
    {
        public Tb02193()
        {
            Tb02195 = new HashSet<Tb02195>();
            Tb02225 = new HashSet<Tb02225>();
        }

        public DateTime? Tb02193Dtcad { get; set; }
        public string Tb02193Opcad { get; set; }
        public DateTime? Tb02193Dtalt { get; set; }
        public string Tb02193Opalt { get; set; }
        public string Tb02193Codigo { get; set; }
        public string Tb02193Nome { get; set; }
        public DateTime? Tb02193Data { get; set; }
        public string Tb02193Obra { get; set; }
        public int? Tb02193Qtde { get; set; }
        public int? Tb02193Qtderec { get; set; }
        public int? Tb02193Qtdeperda { get; set; }
        public string Tb02193Obs { get; set; }
        public string Tb02193Requisicao { get; set; }
        public string Tb02193Codtec { get; set; }
        public string Tb02193Situacao { get; set; }
        public string Tb02193Codemp { get; set; }
        public int? Tb02193Qtdesaldo { get; set; }
        public int? Tb02193Credcopias { get; set; }
        public string Tb02193Oscliente { get; set; }

        public virtual Tb01007 Tb02193CodempNavigation { get; set; }
        public virtual Tb01024 Tb02193CodtecNavigation { get; set; }
        public virtual Tb02190 Tb02193ObraNavigation { get; set; }
        public virtual ICollection<Tb02195> Tb02195 { get; set; }
        public virtual ICollection<Tb02225> Tb02225 { get; set; }
    }
}