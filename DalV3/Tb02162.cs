using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02162
    {
        public string Tb02162Codigo { get; set; }
        public string Tb02162Dataref { get; set; }
        public string Tb02162Codfunc { get; set; }
        public int? Tb02162Dtrab { get; set; }
        public string Tb02162Horaex { get; set; }
        public decimal? Tb02162Horaexunt { get; set; }
        public decimal? Tb02162Horaexval { get; set; }
        public string Tb02162Outrosdescr { get; set; }
        public decimal? Tb02162Outrosrval { get; set; }
        public decimal? Tb02162Valetr { get; set; }
        public decimal? Tb02162Valeal { get; set; }
        public decimal? Tb02162Ajudacusto { get; set; }
        public decimal? Tb02162Subtotalr { get; set; }
        public decimal? Tb02162Adiantd { get; set; }
        public decimal? Tb02162Sindicald { get; set; }
        public string Tb02162Inssperc { get; set; }
        public decimal? Tb02162Inssd { get; set; }
        public decimal? Tb02162Valetrd { get; set; }
        public string Tb02162Faltasnjus { get; set; }
        public decimal? Tb02162Faltasvald { get; set; }
        public string Tb02162Irperc { get; set; }
        public decimal? Tb02162Irtotald { get; set; }
        public string Tb02162Outrosdescd { get; set; }
        public decimal? Tb02162Outrosd { get; set; }
        public int? Tb02162Valepar { get; set; }
        public decimal? Tb02162Vlparcela { get; set; }
        public decimal? Tb02162Valed { get; set; }
        public decimal? Tb02162Subtotald { get; set; }
        public decimal? Tb02162Total { get; set; }
        public decimal? Tb02162Vlroutros { get; set; }
        public decimal? Tb02162Vlrsaude { get; set; }

        public virtual Tb01001 Tb02162CodfuncNavigation { get; set; }
    }
}