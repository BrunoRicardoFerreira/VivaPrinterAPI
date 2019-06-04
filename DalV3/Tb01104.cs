using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01104
    {
        public Tb01104()
        {
            Tb02192 = new HashSet<Tb02192>();
        }

        public DateTime? Tb01104Dtcad { get; set; }
        public string Tb01104Opcad { get; set; }
        public DateTime? Tb01104Dtalt { get; set; }
        public string Tb01104Opalt { get; set; }
        public string Tb01104Codigo { get; set; }
        public string Tb01104Nome { get; set; }
        public string Tb01104Situacao { get; set; }
        public string Tb01104Produto { get; set; }

        public virtual Tb01010 Tb01104ProdutoNavigation { get; set; }
        public virtual ICollection<Tb02192> Tb02192 { get; set; }
    }
}