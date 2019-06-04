using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04031
    {
        public string Tb04031Codfor { get; set; }
        public string Tb04031Codigo { get; set; }
        public DateTime? Tb04031Data { get; set; }
        public decimal? Tb04031Valor { get; set; }
        public string Tb04031Rma { get; set; }
        public string Tb04031Compra { get; set; }
        public DateTime? Tb04031Datausada { get; set; }
        public string Tb04031Nome { get; set; }
        public DateTime? Tb04031Dtcad { get; set; }
        public string Tb04031Opcad { get; set; }
        public DateTime? Tb04031Dtalt { get; set; }
        public string Tb04031Opalt { get; set; }
        public int? Tb04031Tipo { get; set; }
        public string Tb04031Situacao { get; set; }
        public decimal? Tb04031Vlrpago { get; set; }
        public string Tb04031Tipocredito { get; set; }
        public string Tb04031Codban { get; set; }
        public string Tb04031Codcon { get; set; }
        public decimal? Tb04031Vlroriginal { get; set; }
        public string Tb04031Tipocad { get; set; }
        public string Tb04031Prest { get; set; }
        public string Tb04031Codemp { get; set; }

        public virtual Tb04008 Tb04031CodbanNavigation { get; set; }
        public virtual Tb04009 Tb04031CodconNavigation { get; set; }
        public virtual Tb01001 Tb04031CodforNavigation { get; set; }
        public virtual Tb01017 Tb04031PrestNavigation { get; set; }
    }
}