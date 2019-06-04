using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02188
    {
        public Tb02188()
        {
            Tb02189 = new HashSet<Tb02189>();
        }

        public DateTime? Tb02188Dtcad { get; set; }
        public string Tb02188Opcad { get; set; }
        public DateTime? Tb02188Dtalt { get; set; }
        public string Tb02188Opalt { get; set; }
        public string Tb02188Codigo { get; set; }
        public string Tb02188Codemp { get; set; }
        public DateTime? Tb02188Data { get; set; }
        public string Tb02188Codcli { get; set; }
        public string Tb02188Nome { get; set; }
        public string Tb02188Obs { get; set; }
        public int? Tb02188Qtde { get; set; }
        public string Tb02188Situacao { get; set; }
        public string Tb02188Contrato { get; set; }
        public string Tb02188Orcamento { get; set; }
        public string Tb02188Pedido { get; set; }
        public string Tb02188Site { get; set; }
        public string Tb02188Deposito { get; set; }
        public string Tb02188Solicitante { get; set; }
        public string Tb02188Numserie { get; set; }

        public virtual Tb01008 Tb02188CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02188CodempNavigation { get; set; }
        public virtual Tb02111 Tb02188ContratoNavigation { get; set; }
        public virtual ICollection<Tb02189> Tb02189 { get; set; }
    }
}