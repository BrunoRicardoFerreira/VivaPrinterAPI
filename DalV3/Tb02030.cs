using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02030
    {
        public Tb02030()
        {
            Tb02031 = new HashSet<Tb02031>();
            Tb02032 = new HashSet<Tb02032>();
        }

        public DateTime? Tb02030Dtcad { get; set; }
        public string Tb02030Opcad { get; set; }
        public DateTime? Tb02030Dtalt { get; set; }
        public string Tb02030Opalt { get; set; }
        public decimal? Tb02030Baseicms { get; set; }
        public decimal? Tb02030Baseicmssub { get; set; }
        public string Tb02030Codemp { get; set; }
        public string Tb02030Codfor { get; set; }
        public string Tb02030Codigo { get; set; }
        public string Tb02030Condpag { get; set; }
        public DateTime? Tb02030Data { get; set; }
        public DateTime? Tb02030Dtent { get; set; }
        public decimal? Tb02030Despadd { get; set; }
        public string Tb02030Espercie { get; set; }
        public string Tb02030Marca { get; set; }
        public string Tb02030Ntfisc { get; set; }
        public string Tb02030Numero { get; set; }
        public string Tb02030Obs { get; set; }
        public string Tb02030Obsadd { get; set; }
        public decimal? Tb02030Percdesconto { get; set; }
        public decimal? Tb02030Qtde { get; set; }
        public decimal? Tb02030Qtder { get; set; }
        public int? Tb02030Qtvolumes { get; set; }
        public string Tb02030Situacao { get; set; }
        public string Tb02030Transp { get; set; }
        public decimal? Tb02030Vlrbruto { get; set; }
        public decimal? Tb02030Vlrdesconto { get; set; }
        public decimal? Tb02030Vlrfrete { get; set; }
        public decimal? Tb02030Vlricms { get; set; }
        public decimal? Tb02030Vlricmssub { get; set; }
        public decimal? Tb02030Vlripi { get; set; }
        public decimal? Tb02030Vlrnota { get; set; }
        public decimal? Tb02030Vlrnotar { get; set; }
        public decimal? Tb02030Vlroutdesp { get; set; }
        public string Tb02030Natureza { get; set; }
        public string Tb02030Tipototal { get; set; }
        public decimal? Tb02030Vlricmssub2 { get; set; }
        public decimal? Tb02030Vlrbruto2 { get; set; }
        public decimal? Tb02030Vlrdesconto2 { get; set; }
        public decimal? Tb02030Vlrfrete2 { get; set; }
        public decimal? Tb02030Vlrfrete3 { get; set; }
        public decimal? Tb02030Vlripi2 { get; set; }
        public decimal? Tb02030Vlrnota2 { get; set; }
        public string Tb02030Somasub { get; set; }
        public string Tb02030Nome { get; set; }
        public string Tb02030Codcen { get; set; }
        public string Tb02030Codsub { get; set; }
        public string Tb02030Plancon { get; set; }
        public string Tb02030Contabil { get; set; }
        public int? Tb02030Tipofrete { get; set; }
        public string Tb02030Placa { get; set; }
        public string Tb02030Ufplaca { get; set; }
        public decimal? Tb02030Pesobruto { get; set; }
        public decimal? Tb02030Pesoliquido { get; set; }
        public DateTime? Tb02030Datanota { get; set; }
        public string Tb02030Horanota { get; set; }
        public decimal? Tb02030Vlroutdesp2 { get; set; }
        public decimal? Tb02030Baseicms2 { get; set; }
        public decimal? Tb02030Vlricms2 { get; set; }
        public string Tb02030Status { get; set; }
        public string Tb02030Somafrete { get; set; }
        public string Tb02030Opcom { get; set; }
        public string Tb02030Respent { get; set; }
        public decimal? Tb02030Qtdevol { get; set; }
        public decimal? Tb02030Qtdevolr { get; set; }
        public string Tb02030Devlocacao { get; set; }
        public string Tb02030Contrato { get; set; }
        public string Tb02030Codsite { get; set; }
        public string Tb02030Orcamento { get; set; }
        public string Tb02030Pedido { get; set; }
        public string Tb02030Os { get; set; }
        public int? Tb02030Ordem { get; set; }
        public int? Tb02030Kminicial { get; set; }
        public int? Tb02030Kmfinal { get; set; }
        public string Tb02030Hrdesloc { get; set; }
        public string Tb02030Tiposup { get; set; }

        public virtual Tb04004 Tb02030CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02030CodempNavigation { get; set; }
        public virtual Tb01001 Tb02030CodforNavigation { get; set; }
        public virtual Tb04005 Tb02030CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02030CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02030NaturezaNavigation { get; set; }
        public virtual Tb01078 Tb02030OpcomNavigation { get; set; }
        public virtual Tb04006 Tb02030PlanconNavigation { get; set; }
        public virtual Tb01039 Tb02030StatusNavigation { get; set; }
        public virtual Tb01009 Tb02030TranspNavigation { get; set; }
        public virtual ICollection<Tb02031> Tb02031 { get; set; }
        public virtual ICollection<Tb02032> Tb02032 { get; set; }
    }
}