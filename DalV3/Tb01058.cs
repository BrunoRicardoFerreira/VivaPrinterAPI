using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01058
    {
        public string Tb01058Produto { get; set; }
        public string Tb01058Grupo { get; set; }
        public string Tb01058Subgrupo { get; set; }
        public string Tb01058Locpprod { get; set; }
        public string Tb01058Marca { get; set; }

        public virtual Tb01002 Tb01058GrupoNavigation { get; set; }
        public virtual Tb01003 Tb01058LocpprodNavigation { get; set; }
        public virtual Tb01047 Tb01058MarcaNavigation { get; set; }
        public virtual Tb01010 Tb01058ProdutoNavigation { get; set; }
        public virtual Tb01018 Tb01058SubgrupoNavigation { get; set; }
    }
}