using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04009
    {
        public Tb04009()
        {
            Tb01080 = new HashSet<Tb01080>();
            Tb04018 = new HashSet<Tb04018>();
            Tb04030 = new HashSet<Tb04030>();
            Tb04031 = new HashSet<Tb04031>();
            Tb04043 = new HashSet<Tb04043>();
            Tb04051 = new HashSet<Tb04051>();
        }

        public DateTime? Tb04009Dtcad { get; set; }
        public string Tb04009Opcad { get; set; }
        public DateTime? Tb04009Dtalt { get; set; }
        public string Tb04009Opalt { get; set; }
        public string Tb04009Banco { get; set; }
        public string Tb04009Codagen { get; set; }
        public string Tb04009Codcon { get; set; }
        public string Tb04009Codigo { get; set; }
        public string Tb04009Nome { get; set; }
        public string Tb04009Situacao { get; set; }
        public string Tb04009Analisecaixa { get; set; }
        public string Tb04009Restrita { get; set; }
        public string Tb04009Analiseresultado { get; set; }
        public string Tb04009Codemp { get; set; }
        public string Tb04009Codcen { get; set; }
        public string Tb04009Codsub { get; set; }
        public string Tb04009Plancon { get; set; }
        public string Tb04009Localpg { get; set; }
        public string Tb04009Especie { get; set; }
        public string Tb04009Moeda { get; set; }
        public string Tb04009Carteira { get; set; }
        public string Tb04009Nossonum { get; set; }
        public string Tb04009Aceite { get; set; }
        public string Tb04009Obs { get; set; }
        public string Tb04009Codigoempresa { get; set; }
        public int? Tb04009Sequencia { get; set; }
        public string Tb04009Resumofinanc { get; set; }
        public string Tb04009Codtrans { get; set; }
        public int? Tb04009Diasjuros { get; set; }
        public decimal? Tb04009Vlrjuros { get; set; }
        public decimal? Tb04009Vlrmulta { get; set; }
        public int? Tb04009Diasprotesto { get; set; }
        public int? Tb04009Tiporemessa { get; set; }
        public string Tb04009Sicob { get; set; }
        public string Tb04009Tipoend { get; set; }
        public string Tb04009Documento { get; set; }
        public string Tb04009Despbancaria { get; set; }
        public string Tb04009Codprotesto { get; set; }
        public string Tb04009Codbaixadev { get; set; }
        public int? Tb04009Diasbaixadev { get; set; }
        public string Tb04009Vinculado { get; set; }
        public string Tb04009Nbc { get; set; }
        public string Tb04009Nbcnome { get; set; }
        public string Tb04009Nbccnpj { get; set; }
        public string Tb04009Nbclogradouro { get; set; }
        public string Tb04009Nbcnumero { get; set; }
        public string Tb04009Nbccomplemento { get; set; }
        public string Tb04009Nbcbairro { get; set; }
        public string Tb04009Nbccidade { get; set; }
        public string Tb04009Nbccep { get; set; }
        public string Tb04009Nbcuf { get; set; }

        public virtual Tb04008 Tb04009BancoNavigation { get; set; }
        public virtual Tb04004 Tb04009CodcenNavigation { get; set; }
        public virtual Tb04005 Tb04009CodsubNavigation { get; set; }
        public virtual Tb04003 Tb04009DocumentoNavigation { get; set; }
        public virtual Tb04006 Tb04009PlanconNavigation { get; set; }
        public virtual ICollection<Tb01080> Tb01080 { get; set; }
        public virtual ICollection<Tb04018> Tb04018 { get; set; }
        public virtual ICollection<Tb04030> Tb04030 { get; set; }
        public virtual ICollection<Tb04031> Tb04031 { get; set; }
        public virtual ICollection<Tb04043> Tb04043 { get; set; }
        public virtual ICollection<Tb04051> Tb04051 { get; set; }
    }
}