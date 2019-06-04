using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02168
    {
        public Tb02168()
        {
            Tb02169 = new HashSet<Tb02169>();
            Tb02171 = new HashSet<Tb02171>();
        }

        public string Tb02168Codigo { get; set; }
        public string Tb02168Produto { get; set; }
        public int Tb02168Id { get; set; }
        public string Tb02168Void { get; set; }
        public string Tb02168Garantia { get; set; }
        public decimal? Tb02168Peso { get; set; }
        public decimal? Tb02168Peso2 { get; set; }
        public string Tb02168Laudo { get; set; }
        public string Tb02168Codtec { get; set; }
        public string Tb02168Indevida { get; set; }
        public string Tb02168Carcaca { get; set; }
        public string Tb02168Reprovado { get; set; }
        public string Tb02168Resposta { get; set; }

        public virtual Tb02166 Tb02168CodigoNavigation { get; set; }
        public virtual Tb02167 Tb02168Navigation { get; set; }
        public virtual Tb01010 Tb02168ProdutoNavigation { get; set; }
        public virtual ICollection<Tb02169> Tb02169 { get; set; }
        public virtual ICollection<Tb02171> Tb02171 { get; set; }
    }
}