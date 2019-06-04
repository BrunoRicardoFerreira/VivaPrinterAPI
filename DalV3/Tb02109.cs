using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02109
    {
        public DateTime? Tb02109Dtcad { get; set; }
        public string Tb02109Opcad { get; set; }
        public int Tb02109Trocaid { get; set; }
        public string Tb02109Produto { get; set; }
        public string Tb02109Tipo { get; set; }
        public int Tb02109Prodid { get; set; }
        public string Tb02109Numserie { get; set; }
        public string Tb02109Operacao { get; set; }
        public string Tb02109Nummov { get; set; }
        public string Tb02109Nome { get; set; }
        public int Tb02109Serieid { get; set; }

        public virtual Tb02108 Tb02109Navigation { get; set; }
        public virtual Tb01010 Tb02109ProdutoNavigation { get; set; }
    }
}