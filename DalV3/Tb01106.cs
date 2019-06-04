using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01106
    {
        public DateTime? Tb01106Dtcad { get; set; }
        public string Tb01106Opcad { get; set; }
        public DateTime? Tb01106Dtalt { get; set; }
        public string Tb01106Opalt { get; set; }
        public string Tb01106Obra { get; set; }
        public string Tb01106Codserv { get; set; }
        public string Tb01106Produto { get; set; }
        public decimal? Tb01106Qtde { get; set; }

        public virtual Tb02192 Tb01106CodservNavigation { get; set; }
        public virtual Tb02190 Tb01106ObraNavigation { get; set; }
        public virtual Tb01010 Tb01106ProdutoNavigation { get; set; }
    }
}