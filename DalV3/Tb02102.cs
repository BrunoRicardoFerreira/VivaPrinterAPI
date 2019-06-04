using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02102
    {
        public Tb02102()
        {
            Tb02137 = new HashSet<Tb02137>();
        }

        public string Tb02102Codcli { get; set; }
        public string Tb02102Codven { get; set; }
        public DateTime? Tb02102Realizado { get; set; }
        public DateTime? Tb02102Programado { get; set; }
        public string Tb02102Contato { get; set; }
        public int? Tb02102Avaliacao { get; set; }
        public string Tb02102Resultado { get; set; }
        public string Tb02102Cancelado { get; set; }
        public DateTime? Tb02102Data { get; set; }
        public string Tb02102Opcad { get; set; }
        public string Tb02102Opatual { get; set; }
        public string Tb02102Obs { get; set; }
        public string Tb02102Status { get; set; }
        public string Tb02102Statusatu { get; set; }
        public DateTime? Tb02102Concluido { get; set; }
        public int? Tb02102Tipouser { get; set; }
        public string Tb02102Usuarios { get; set; }
        public string Tb02102Numorc { get; set; }
        public string Tb02102Tipo { get; set; }
        public int Tb02102Codigo { get; set; }
        public string Tb02102Class { get; set; }
        public int? Tb02102Qtde { get; set; }
        public decimal? Tb02102Vlrproposta { get; set; }
        public string Tb02102Contrato { get; set; }
        public int? Tb02102Ordem { get; set; }
        public int? Tb02102Kminicial { get; set; }
        public int? Tb02102Kmfinal { get; set; }

        public virtual Tb01087 Tb02102ClassNavigation { get; set; }
        public virtual Tb01044 Tb02102StatusNavigation { get; set; }
        public virtual Tb01044 Tb02102StatusatuNavigation { get; set; }
        public virtual ICollection<Tb02137> Tb02137 { get; set; }
    }
}