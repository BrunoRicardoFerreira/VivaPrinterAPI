using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04018
    {
        public DateTime? Tb04018Dtcad { get; set; }
        public string Tb04018Opcad { get; set; }
        public DateTime? Tb04018Dtalt { get; set; }
        public string Tb04018Opalt { get; set; }
        public string Tb04018Codcadbanco { get; set; }
        public string Tb04018Compensado { get; set; }
        public DateTime Tb04018Data { get; set; }
        public string Tb04018Documento { get; set; }
        public string Tb04018Historico { get; set; }
        public decimal? Tb04018Saldo { get; set; }
        public string Tb04018Tipo { get; set; }
        public decimal? Tb04018Valor { get; set; }
        public string Tb04018Obs { get; set; }
        public string Tb04018Banco { get; set; }
        public string Tb04018Destino { get; set; }
        public string Tb04018Venda1 { get; set; }
        public string Tb04018Venda2 { get; set; }
        public string Tb04018Venda3 { get; set; }
        public string Tb04018Venda4 { get; set; }
        public string Tb04018Venda5 { get; set; }
        public decimal? Tb04018Saldoc { get; set; }

        public virtual Tb04009 Tb04018CodcadbancoNavigation { get; set; }
    }
}