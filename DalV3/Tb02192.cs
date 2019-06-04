using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02192
    {
        public Tb02192()
        {
            Tb01106 = new HashSet<Tb01106>();
            Tb02225 = new HashSet<Tb02225>();
        }

        public DateTime? Tb02192Dtcad { get; set; }
        public string Tb02192Opcad { get; set; }
        public DateTime? Tb02192Dtalt { get; set; }
        public string Tb02192Opalt { get; set; }
        public string Tb02192Obra { get; set; }
        public string Tb02192Codserv { get; set; }
        public string Tb02192Tipopapel { get; set; }
        public decimal? Tb02192Custo { get; set; }
        public string Tb02192Duplex { get; set; }
        public string Tb02192Nome { get; set; }
        public string Tb02192Codigo { get; set; }
        public string Tb02192Cobrar { get; set; }
        public string Tb02192Contpagina { get; set; }
        public string Tb02192Gerarrequisicao { get; set; }
        public int? Tb02192Qtcopias { get; set; }
        public int? Tb02192Qtcopiasb { get; set; }
        public decimal? Tb02192Totvalor { get; set; }
        public decimal? Tb02192Totvalorb { get; set; }

        public virtual Tb01094 Tb02192CodservNavigation { get; set; }
        public virtual Tb02190 Tb02192ObraNavigation { get; set; }
        public virtual Tb01104 Tb02192TipopapelNavigation { get; set; }
        public virtual ICollection<Tb01106> Tb01106 { get; set; }
        public virtual ICollection<Tb02225> Tb02225 { get; set; }
    }
}