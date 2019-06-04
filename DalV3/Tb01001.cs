using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01001
    {
        public Tb01001()
        {
            Tb01010Tb01010FornNavigation = new HashSet<Tb01010>();
            Tb01010Tb01010Forncom1Navigation = new HashSet<Tb01010>();
            Tb01010Tb01010Forncom2Navigation = new HashSet<Tb01010>();
            Tb01010Tb01010Forncom3Navigation = new HashSet<Tb01010>();
            Tb01010Tb01010Forncom4Navigation = new HashSet<Tb01010>();
            Tb01032 = new HashSet<Tb01032>();
            Tb02002 = new HashSet<Tb02002>();
            Tb02009 = new HashSet<Tb02009>();
            Tb02015 = new HashSet<Tb02015>();
            Tb02030 = new HashSet<Tb02030>();
            Tb02059 = new HashSet<Tb02059>();
            Tb02065 = new HashSet<Tb02065>();
            Tb02066 = new HashSet<Tb02066>();
            Tb02067 = new HashSet<Tb02067>();
            Tb02068 = new HashSet<Tb02068>();
            Tb02073 = new HashSet<Tb02073>();
            Tb02087 = new HashSet<Tb02087>();
            Tb02100 = new HashSet<Tb02100>();
            Tb02162 = new HashSet<Tb02162>();
            Tb04014 = new HashSet<Tb04014>();
            Tb04026 = new HashSet<Tb04026>();
            Tb04031 = new HashSet<Tb04031>();
            Tb04036 = new HashSet<Tb04036>();
            Tb04038 = new HashSet<Tb04038>();
            Tb04040 = new HashSet<Tb04040>();
            Tb04051 = new HashSet<Tb04051>();
        }

        public DateTime? Tb01001Dtcad { get; set; }
        public string Tb01001Opcad { get; set; }
        public DateTime? Tb01001Dtalt { get; set; }
        public string Tb01001Opalt { get; set; }
        public string Tb01001Cnpj { get; set; }
        public string Tb01001Codigo { get; set; }
        public string Tb01001Compra { get; set; }
        public string Tb01001Cpf { get; set; }
        public string Tb01001Despesa { get; set; }
        public int? Tb01001Diasentrega { get; set; }
        public string Tb01001Fantasia { get; set; }
        public int? Tb01001Frete { get; set; }
        public string Tb01001Ident { get; set; }
        public string Tb01001Inativo { get; set; }
        public string Tb01001Inscest { get; set; }
        public string Tb01001Inscmun { get; set; }
        public string Tb01001Nome { get; set; }
        public string Tb01001Obs { get; set; }
        public string Tb01001Pessoa { get; set; }
        public string Tb01001Transp { get; set; }
        public string Tb01001Codcen { get; set; }
        public string Tb01001Codsub { get; set; }
        public string Tb01001Plancon { get; set; }
        public decimal? Tb01001Percreduz { get; set; }
        public string Tb01001Func { get; set; }
        public string Tb01001Estcev { get; set; }
        public string Tb01001Cargo { get; set; }
        public DateTime? Tb01001Dnasc { get; set; }
        public string Tb01001Escl { get; set; }
        public string Tb01001Ctps { get; set; }
        public string Tb01001Cnh { get; set; }
        public string Tb01001Pis { get; set; }
        public string Tb01001Tituloe { get; set; }
        public string Tb01001Empresa { get; set; }
        public DateTime? Tb01001Dtadmissao { get; set; }
        public DateTime? Tb01001Dtdesliga { get; set; }
        public string Tb01001Inferias { get; set; }
        public DateTime? Tb01001Ultferias { get; set; }
        public string Tb01001Ent { get; set; }
        public string Tb01001Intervalo { get; set; }
        public string Tb01001Saida { get; set; }
        public int? Tb01001Valetrqt { get; set; }
        public int? Tb01001Filhos { get; set; }
        public int? Tb01001Filhos2 { get; set; }
        public decimal? Tb01001Salario { get; set; }
        public decimal? Tb01001Salariof { get; set; }
        public decimal? Tb01001Gratif { get; set; }
        public string Tb01001Agencia { get; set; }
        public string Tb01001Conta { get; set; }
        public string Tb01001Tipo { get; set; }
        public decimal? Tb01001Valetr { get; set; }
        public decimal? Tb01001Valeal { get; set; }
        public decimal? Tb01001Ajudacusto { get; set; }
        public string Tb01001Estciv { get; set; }
        public string Tb01001Codban { get; set; }
        public string Tb01001Vendedor { get; set; }
        public string Tb01001Codven { get; set; }
        public string Tb01001Grupo { get; set; }

        public virtual Tb04008 Tb01001CodbanNavigation { get; set; }
        public virtual Tb04004 Tb01001CodcenNavigation { get; set; }
        public virtual Tb04005 Tb01001CodsubNavigation { get; set; }
        public virtual Tb01107 Tb01001GrupoNavigation { get; set; }
        public virtual Tb04006 Tb01001PlanconNavigation { get; set; }
        public virtual Tb01009 Tb01001TranspNavigation { get; set; }
        public virtual ICollection<Tb01010> Tb01010Tb01010FornNavigation { get; set; }
        public virtual ICollection<Tb01010> Tb01010Tb01010Forncom1Navigation { get; set; }
        public virtual ICollection<Tb01010> Tb01010Tb01010Forncom2Navigation { get; set; }
        public virtual ICollection<Tb01010> Tb01010Tb01010Forncom3Navigation { get; set; }
        public virtual ICollection<Tb01010> Tb01010Tb01010Forncom4Navigation { get; set; }
        public virtual ICollection<Tb01032> Tb01032 { get; set; }
        public virtual ICollection<Tb02002> Tb02002 { get; set; }
        public virtual ICollection<Tb02009> Tb02009 { get; set; }
        public virtual ICollection<Tb02015> Tb02015 { get; set; }
        public virtual ICollection<Tb02030> Tb02030 { get; set; }
        public virtual ICollection<Tb02059> Tb02059 { get; set; }
        public virtual ICollection<Tb02065> Tb02065 { get; set; }
        public virtual ICollection<Tb02066> Tb02066 { get; set; }
        public virtual ICollection<Tb02067> Tb02067 { get; set; }
        public virtual ICollection<Tb02068> Tb02068 { get; set; }
        public virtual ICollection<Tb02073> Tb02073 { get; set; }
        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb02100> Tb02100 { get; set; }
        public virtual ICollection<Tb02162> Tb02162 { get; set; }
        public virtual ICollection<Tb04014> Tb04014 { get; set; }
        public virtual ICollection<Tb04026> Tb04026 { get; set; }
        public virtual ICollection<Tb04031> Tb04031 { get; set; }
        public virtual ICollection<Tb04036> Tb04036 { get; set; }
        public virtual ICollection<Tb04038> Tb04038 { get; set; }
        public virtual ICollection<Tb04040> Tb04040 { get; set; }
        public virtual ICollection<Tb04051> Tb04051 { get; set; }
    }
}