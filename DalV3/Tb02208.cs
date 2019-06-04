using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02208
    {
        public string Tb02208Pedido { get; set; }
        public string Tb02208Conferencia { get; set; }
        public string Tb02208Compra { get; set; }
        public string Tb02208Contrato { get; set; }
        public string Tb02208Produto { get; set; }
        public string Tb02208Numserie { get; set; }
        public string Tb02208Pat { get; set; }
        public int? Tb02208Contpb { get; set; }
        public int? Tb02208Contcolor { get; set; }
        public string Tb02208Acessorio { get; set; }

        public virtual Tb02111 Tb02208ContratoNavigation { get; set; }
        public virtual Tb01010 Tb02208ProdutoNavigation { get; set; }
    }
}