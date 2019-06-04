using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02215
    {
        public string Tb02215Codemp { get; set; }
        public string Tb02215Tabela { get; set; }
        public string Tb02215Codigo { get; set; }
        public string Tb02215Produto { get; set; }
        public string Tb02215Locpprod { get; set; }
        public DateTime Tb02215Data { get; set; }
        public string Tb02215Operador { get; set; }
        public decimal? Tb02215Qtprod { get; set; }
        public string Tb02215Operacao { get; set; }
        public string Tb02215Tipoestoque { get; set; }
        public decimal? Tb02215Estoque { get; set; }
        public string Tb02215Lido { get; set; }
        public string Tb02215Lidopor { get; set; }

        public virtual Tb01007 Tb02215CodempNavigation { get; set; }
        public virtual Tb01003 Tb02215LocpprodNavigation { get; set; }
        public virtual Tb01010 Tb02215ProdutoNavigation { get; set; }
    }
}