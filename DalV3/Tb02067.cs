using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02067
    {
        public int Tb02067Cotacao { get; set; }
        public string Tb02067Forn { get; set; }
        public decimal? Tb02067Qtde { get; set; }
        public decimal? Tb02067Valor { get; set; }
        public string Tb02067Numped { get; set; }
        public string Tb02067Condpag { get; set; }
        public string Tb02067Status { get; set; }
        public string Tb02067Transp { get; set; }
        public string Tb02067Cfop { get; set; }
        public string Tb02067Plancon { get; set; }
        public string Tb02067Codcen { get; set; }
        public string Tb02067Codsub { get; set; }
        public DateTime? Tb02067Dtentrega { get; set; }
        public string Tb02067Opcom { get; set; }

        public virtual Tb02063 Tb02067CotacaoNavigation { get; set; }
        public virtual Tb01001 Tb02067FornNavigation { get; set; }
    }
}