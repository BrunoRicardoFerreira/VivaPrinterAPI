using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02127
    {
        public DateTime? Tb02127Dtcad { get; set; }
        public string Tb02127Opcad { get; set; }
        public DateTime? Tb02127Dtalt { get; set; }
        public string Tb02127Opalt { get; set; }
        public string Tb02127Mes { get; set; }
        public string Tb02127Contrato { get; set; }
        public string Tb02127Produto { get; set; }
        public string Tb02127Numserie { get; set; }
        public decimal? Tb02127Vlrcontr { get; set; }
        public decimal? Tb02127Vlrtiradaspb { get; set; }
        public decimal? Tb02127Vlrtiradascor { get; set; }
        public decimal? Tb02127Vlrexcedpb { get; set; }
        public decimal? Tb02127Vlrexcedcor { get; set; }
        public decimal? Tb02127Vlrtotal { get; set; }
        public decimal? Tb02127Vlrtiradasdg { get; set; }
        public decimal? Tb02127Vlrtiradasgf { get; set; }
        public decimal? Tb02127Vlrexceddg { get; set; }
        public decimal? Tb02127Vlrexcedgf { get; set; }
        public decimal? Tb02127Vlrserv { get; set; }
        public decimal? Tb02127Vlrunitirapb { get; set; }
        public decimal? Tb02127Vlrunitiracor { get; set; }
        public decimal? Tb02127Vlrunitiradg { get; set; }
        public decimal? Tb02127Vlrunitiragf { get; set; }
        public decimal? Tb02127Vlruniexcedpb { get; set; }
        public decimal? Tb02127Vlruniexcedcor { get; set; }
        public decimal? Tb02127Vlruniexceddg { get; set; }
        public decimal? Tb02127Vlruniexcedgf { get; set; }
        public decimal? Tb02127Vlruniserv { get; set; }
        public decimal? Tb02127Vlrtiradasgfc { get; set; }
        public decimal? Tb02127Vlrexcedgfc { get; set; }
        public decimal? Tb02127Vlrunitiragfc { get; set; }
        public decimal? Tb02127Vlruniexcedgfc { get; set; }
        public decimal? Tb02127Vlrunitpb { get; set; }
        public decimal? Tb02127Vlrunitcor { get; set; }
        public decimal? Tb02127Vlrunitdig { get; set; }
        public decimal? Tb02127Vlrunitgf { get; set; }
        public decimal? Tb02127Vlrunitgfc { get; set; }

        public virtual Tb02111 Tb02127ContratoNavigation { get; set; }
        public virtual Tb02112 Tb02127Navigation { get; set; }
        public virtual Tb01010 Tb02127ProdutoNavigation { get; set; }
    }
}