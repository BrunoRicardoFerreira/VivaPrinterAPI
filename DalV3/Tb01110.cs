using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01110
    {
        public string Tb01110Codemp { get; set; }
        public string Tb01110Produto { get; set; }
        public DateTime? Tb01110Dtpreco { get; set; }
        public string Tb01110Formapreco { get; set; }
        public decimal? Tb01110Custo { get; set; }
        public decimal? Tb01110Custoi { get; set; }
        public decimal? Tb01110Custou { get; set; }
        public decimal? Tb01110Markup { get; set; }
        public decimal? Tb01110Vendam { get; set; }
        public decimal? Tb01110Vlripi { get; set; }
        public decimal? Tb01110Vlrst { get; set; }
        public DateTime? Tb01110Dtvpro1 { get; set; }
        public DateTime? Tb01110Dtvpro2 { get; set; }
        public decimal? Tb01110Venda { get; set; }
        public decimal? Tb01110Vendap { get; set; }
        public decimal? Tb01110Vendapro { get; set; }
        public decimal? Tb01110Vendafim { get; set; }
        public string Tb01110Clfisc { get; set; }
        public decimal? Tb01110Icms { get; set; }
        public decimal? Tb01110Icmsimp { get; set; }
        public decimal? Tb01110Icmsst { get; set; }
        public string Tb01110Sit { get; set; }
        public decimal? Tb01110Aliqcsll { get; set; }
        public decimal? Tb01110Ipi { get; set; }
        public decimal? Tb01110Aliqpis { get; set; }
        public decimal? Tb01110Aliqcofins { get; set; }
        public decimal? Tb01110Aliqimpfat { get; set; }
        public decimal? Tb01110Icms2 { get; set; }
        public decimal? Tb01110Mva { get; set; }
        public decimal? Tb01110Basered { get; set; }
        public decimal? Tb01110Ir { get; set; }
        public decimal? Tb01110Ipi2 { get; set; }
        public string Tb01110Tpicms { get; set; }
        public string Tb01110Cstcofins { get; set; }
        public string Tb01110Cstpis { get; set; }
        public string Tb01110Cstipi { get; set; }
        public string Tb01110Cest { get; set; }
        public string Tb01110Cfopdentro { get; set; }
        public string Tb01110Cfopfora { get; set; }
        public decimal? Tb01110Re { get; set; }
        public decimal? Tb01110Re2 { get; set; }
        public string Tb01110Natop { get; set; }
        public decimal? Tb01110Fcp { get; set; }
        public decimal? Tb01110Fcpst { get; set; }
        public decimal? Tb01110Custocompra { get; set; }
        public decimal? Tb01110Custocompramed { get; set; }
        public decimal? Tb01110Custocomprau { get; set; }
        public decimal? Tb01110Custocompramedu { get; set; }
        public decimal? Tb01110Custocomprai { get; set; }
        public decimal? Tb01110Custocompramedi { get; set; }
        public decimal? Tb01110Customed { get; set; }
        public decimal? Tb01110Customedi { get; set; }
        public decimal? Tb01110Customedu { get; set; }
        public string Tb01110Tpicmsc { get; set; }
        public decimal? Tb01110Icmsc { get; set; }
        public string Tb01110Cstpisc { get; set; }
        public string Tb01110Cstcofinsc { get; set; }
        public decimal? Tb01110Aliqcofinsc { get; set; }
        public decimal? Tb01110Ipic { get; set; }
        public string Tb01110Locpprod { get; set; }
        public string Tb01110Locpprod2 { get; set; }
        public string Tb01110Locpprod3 { get; set; }
        public string Tb01110Locpprod4 { get; set; }
        public string Tb01110Prateleira { get; set; }
        public string Tb01110Prateleira2 { get; set; }
        public string Tb01110Prateleira3 { get; set; }
        public string Tb01110Prateleira4 { get; set; }
        public int? Tb01110Orig { get; set; }
        public decimal? Tb01110Aliqpisc { get; set; }
        public string Tb01110Cstipic { get; set; }

        public virtual Tb01007 Tb01110CodempNavigation { get; set; }
        public virtual Tb01010 Tb01110ProdutoNavigation { get; set; }
    }
}