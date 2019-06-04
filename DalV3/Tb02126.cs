using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02126
    {
        public DateTime? Tb02126Dtcad { get; set; }
        public string Tb02126Opcad { get; set; }
        public DateTime? Tb02126Dtalt { get; set; }
        public string Tb02126Opalt { get; set; }
        public string Tb02126Mes { get; set; }
        public string Tb02126Contrato { get; set; }
        public string Tb02126Codcli { get; set; }
        public decimal? Tb02126Vlrcontr { get; set; }
        public decimal? Tb02126Vlrtiradaspb { get; set; }
        public decimal? Tb02126Vlrtiradascor { get; set; }
        public decimal? Tb02126Vlrexcedpb { get; set; }
        public decimal? Tb02126Vlrexcedcor { get; set; }
        public decimal? Tb02126Vlrtotal { get; set; }
        public string Tb02126Recibo { get; set; }
        public string Tb02126Codvenda { get; set; }
        public decimal? Tb02126Vlrbruto { get; set; }
        public decimal? Tb02126Perdesc { get; set; }
        public decimal? Tb02126Vlrdesc { get; set; }
        public string Tb02126Apleitura { get; set; }
        public decimal? Tb02126Vlrtiradasdg { get; set; }
        public decimal? Tb02126Vlrtiradasgf { get; set; }
        public decimal? Tb02126Vlrexceddg { get; set; }
        public decimal? Tb02126Vlrexcedgf { get; set; }
        public decimal? Tb02126Vlrretencoes { get; set; }
        public decimal? Tb02126Vlrserv { get; set; }
        public int? Tb02126Lote { get; set; }
        public decimal? Tb02126Caucao { get; set; }
        public decimal? Tb02126Vlrcaucao { get; set; }
        public decimal? Tb02126Vlrtiradasgfc { get; set; }
        public decimal? Tb02126Vlrexcedgfc { get; set; }
        public string Tb02126Liberado { get; set; }
        public string Tb02126PeriodoIncial { get; set; }
        public string Tb02126PeriodoFinal { get; set; }
        public decimal? Tb02126Vlrnotapb { get; set; }
        public decimal? Tb02126Vlrnotacl { get; set; }
        public decimal? Tb02126Vlrnotadg { get; set; }
        public decimal? Tb02126Vlrnotagf { get; set; }
        public decimal? Tb02126Vlrnotagfc { get; set; }
        public decimal? Tb02126Vlrfixo { get; set; }

        public virtual Tb01008 Tb02126CodcliNavigation { get; set; }
        public virtual Tb02111 Tb02126ContratoNavigation { get; set; }
    }
}