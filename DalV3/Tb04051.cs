using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04051
    {
        public DateTime? Tb04051Dtcad { get; set; }
        public string Tb04051Opcad { get; set; }
        public DateTime? Tb04051Dtalt { get; set; }
        public string Tb04051Opalt { get; set; }
        public string Tb04051Codemp { get; set; }
        public string Tb04051Codigo { get; set; }
        public DateTime? Tb04051Data { get; set; }
        public string Tb04051Codfor { get; set; }
        public string Tb04051Nome { get; set; }
        public string Tb04051Tipo { get; set; }
        public int? Tb04051Origem { get; set; }
        public string Tb04051Codban { get; set; }
        public string Tb04051Codcon { get; set; }
        public string Tb04051Codcen { get; set; }
        public string Tb04051Codsub { get; set; }
        public string Tb04051Plancon { get; set; }
        public string Tb04051Tipdoc { get; set; }
        public decimal? Tb04051Valor { get; set; }
        public string Tb04051Obs { get; set; }
        public string Tb04051Acerto { get; set; }

        public virtual Tb04008 Tb04051CodbanNavigation { get; set; }
        public virtual Tb04004 Tb04051CodcenNavigation { get; set; }
        public virtual Tb04009 Tb04051CodconNavigation { get; set; }
        public virtual Tb01007 Tb04051CodempNavigation { get; set; }
        public virtual Tb01001 Tb04051CodforNavigation { get; set; }
        public virtual Tb04005 Tb04051CodsubNavigation { get; set; }
        public virtual Tb04006 Tb04051PlanconNavigation { get; set; }
        public virtual Tb04001 Tb04051TipdocNavigation { get; set; }
    }
}