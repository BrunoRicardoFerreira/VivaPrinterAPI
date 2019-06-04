using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01049
    {
        public Tb01049()
        {
            Tb02113 = new HashSet<Tb02113>();
            Tb02128 = new HashSet<Tb02128>();
            Tb02186 = new HashSet<Tb02186>();
        }

        public DateTime? Tb01049Dtcad { get; set; }
        public string Tb01049Opcad { get; set; }
        public DateTime? Tb01049Dtalt { get; set; }
        public DateTime? Tb01049Opalt { get; set; }
        public string Tb01049Codigo { get; set; }
        public string Tb01049Nome { get; set; }
        public string Tb01049Situacao { get; set; }
        public string Tb01049Obs { get; set; }
        public int? Tb01049Dias { get; set; }
        public decimal? Tb01049Comissao { get; set; }
        public string Tb01049Variavel { get; set; }
        public int? Tb01049Tipovariavel { get; set; }
        public string Tb01049Produto { get; set; }
        public string Tb01049Tipogera { get; set; }
        public string Tb01049Codserv { get; set; }
        public int? Tb01049Tiporateio { get; set; }

        public virtual Tb01010 Tb01049ProdutoNavigation { get; set; }
        public virtual ICollection<Tb02113> Tb02113 { get; set; }
        public virtual ICollection<Tb02128> Tb02128 { get; set; }
        public virtual ICollection<Tb02186> Tb02186 { get; set; }
    }
}