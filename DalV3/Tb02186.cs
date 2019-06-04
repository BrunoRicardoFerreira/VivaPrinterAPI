using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02186
    {
        public DateTime? Tb02186Dtcad { get; set; }
        public string Tb02186Opcad { get; set; }
        public DateTime? Tb02186Dtalt { get; set; }
        public string Tb02186Opalt { get; set; }
        public string Tb02186Grupo { get; set; }
        public string Tb02186Cobertura { get; set; }
        public DateTime? Tb02186Validade { get; set; }
        public decimal? Tb02186Valor { get; set; }
        public decimal? Tb02186Valorb { get; set; }
        public decimal? Tb02186Comissao { get; set; }

        public virtual Tb01049 Tb02186CoberturaNavigation { get; set; }
        public virtual Tb02185 Tb02186GrupoNavigation { get; set; }
    }
}