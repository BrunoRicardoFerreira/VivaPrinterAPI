using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04030
    {
        public string Tb04030Codcli { get; set; }
        public string Tb04030Codigo { get; set; }
        public DateTime? Tb04030Data { get; set; }
        public decimal? Tb04030Valor { get; set; }
        public string Tb04030Dev { get; set; }
        public string Tb04030Venda { get; set; }
        public DateTime? Tb04030Datausada { get; set; }
        public string Tb04030Nome { get; set; }
        public DateTime? Tb04030Dtcad { get; set; }
        public string Tb04030Opcad { get; set; }
        public DateTime? Tb04030Dtalt { get; set; }
        public string Tb04030Opalt { get; set; }
        public int? Tb04030Tipo { get; set; }
        public string Tb04030Situacao { get; set; }
        public decimal? Tb04030Vlrpago { get; set; }
        public string Tb04030Tipocredito { get; set; }
        public string Tb04030Codban { get; set; }
        public string Tb04030Codcon { get; set; }
        public string Tb04030Credanterior { get; set; }
        public string Tb04030Pgtoantecip { get; set; }
        public decimal? Tb04030Vlroriginal { get; set; }
        public string Tb04030Codemp { get; set; }

        public virtual Tb04008 Tb04030CodbanNavigation { get; set; }
        public virtual Tb01008 Tb04030CodcliNavigation { get; set; }
        public virtual Tb04009 Tb04030CodconNavigation { get; set; }
    }
}