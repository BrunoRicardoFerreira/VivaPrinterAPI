using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01055
    {
        public Tb01055()
        {
            Tb02122 = new HashSet<Tb02122>();
        }

        public DateTime? Tb01055Dtcad { get; set; }
        public string Tb01055Opcad { get; set; }
        public DateTime? Tb01055Dtalt { get; set; }
        public DateTime? Tb01055Opalt { get; set; }
        public string Tb01055Codigo { get; set; }
        public string Tb01055Nome { get; set; }
        public string Tb01055Situacao { get; set; }
        public string Tb01055Cor { get; set; }
        public string Tb01055Outsourcing { get; set; }
        public string Tb01055Dev { get; set; }
        public string Tb01055Gravaleitura { get; set; }
        public string Tb01055Inst { get; set; }
        public string Tb01055Reqpendente { get; set; }
        public string Tb01055Osreinc { get; set; }
        public string Tb01055Vend { get; set; }
        public string Tb01055Tipodesc { get; set; }
        public string Tb01055Status { get; set; }
        public string Tb01055Status2 { get; set; }
        public string Tb01055Condpag { get; set; }
        public string Tb01055Statusos { get; set; }
        public int? Tb01055Operacao { get; set; }
        public int? Tb01055Tipoestoque { get; set; }

        public virtual Tb01014 Tb01055CondpagNavigation { get; set; }
        public virtual Tb01021 Tb01055Status2Navigation { get; set; }
        public virtual Tb01021 Tb01055StatusNavigation { get; set; }
        public virtual Tb01073 Tb01055StatusosNavigation { get; set; }
        public virtual Tb01022 Tb01055TipodescNavigation { get; set; }
        public virtual Tb01006 Tb01055VendNavigation { get; set; }
        public virtual ICollection<Tb02122> Tb02122 { get; set; }
    }
}