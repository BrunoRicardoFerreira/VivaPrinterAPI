using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02122
    {
        public Tb02122()
        {
            Tb02123 = new HashSet<Tb02123>();
            Tb02124 = new HashSet<Tb02124>();
            Tb02125 = new HashSet<Tb02125>();
            Tb02219 = new HashSet<Tb02219>();
        }

        public DateTime? Tb02122Dtcad { get; set; }
        public string Tb02122Opcad { get; set; }
        public DateTime? Tb02122Dtalt { get; set; }
        public string Tb02122Opalt { get; set; }
        public string Tb02122Codigo { get; set; }
        public string Tb02122Contrato { get; set; }
        public string Tb02122Codcli { get; set; }
        public string Tb02122Produto { get; set; }
        public string Tb02122Numserie { get; set; }
        public DateTime? Tb02122Data { get; set; }
        public string Tb02122Codemp { get; set; }
        public string Tb02122Situacao { get; set; }
        public string Tb02122Numos { get; set; }
        public DateTime? Tb02122Dataini { get; set; }
        public string Tb02122Horaini { get; set; }
        public DateTime? Tb02122Datafim { get; set; }
        public string Tb02122Horafim { get; set; }
        public int? Tb02122Contador { get; set; }
        public int? Tb02122Credcopias { get; set; }
        public string Tb02122Cilindro { get; set; }
        public string Tb02122Sitcilindro { get; set; }
        public int? Tb02122Contcilindro { get; set; }
        public string Tb02122Revelador { get; set; }
        public string Tb02122Condicao { get; set; }
        public string Tb02122Incompleto { get; set; }
        public string Tb02122Servimcompl { get; set; }
        public decimal? Tb02122Vlrserv { get; set; }
        public string Tb02122Numorc { get; set; }
        public string Tb02122Obs { get; set; }
        public string Tb02122Condpag { get; set; }
        public string Tb02122Vend { get; set; }
        public string Tb02122Tipodesc { get; set; }
        public string Tb02122Status { get; set; }
        public DateTime? Tb02122Dtfecha { get; set; }
        public int? Tb02122Contadorc { get; set; }
        public int? Tb02122Credcopiasc { get; set; }
        public string Tb02122Fusor { get; set; }
        public string Tb02122Belt { get; set; }
        public string Tb02122Codtec { get; set; }
        public DateTime? Tb02122Garantia { get; set; }
        public string Tb02122Tipointerv { get; set; }
        public string Tb02122Prest { get; set; }
        public int? Tb02122Kminicial { get; set; }
        public int? Tb02122Kmfinal { get; set; }
        public string Tb02122Cilindroc { get; set; }
        public string Tb02122Reveladorc { get; set; }
        public string Tb02122Sitcilindroc { get; set; }
        public int? Tb02122Contcilindroc { get; set; }
        public string Tb02122Hrdesloc { get; set; }
        public string Tb02122Placa { get; set; }
        public string Tb02122Preventiva { get; set; }
        public string Tb02122Reservatorio { get; set; }
        public int? Tb02122Contadordg { get; set; }
        public int? Tb02122Credcopiasdg { get; set; }
        public int? Tb02122Contadorgf { get; set; }
        public int? Tb02122Credcopiasgf { get; set; }
        public int? Tb02122Contadorgfc { get; set; }
        public int? Tb02122Credcopiasgfc { get; set; }

        public virtual Tb01008 Tb02122CodcliNavigation { get; set; }
        public virtual Tb01024 Tb02122CodtecNavigation { get; set; }
        public virtual Tb01055 Tb02122CondicaoNavigation { get; set; }
        public virtual Tb01014 Tb02122CondpagNavigation { get; set; }
        public virtual Tb02115 Tb02122NumosNavigation { get; set; }
        public virtual Tb01010 Tb02122ProdutoNavigation { get; set; }
        public virtual Tb01056 Tb02122ServimcomplNavigation { get; set; }
        public virtual Tb01021 Tb02122StatusNavigation { get; set; }
        public virtual Tb01022 Tb02122TipodescNavigation { get; set; }
        public virtual Tb01006 Tb02122VendNavigation { get; set; }
        public virtual ICollection<Tb02123> Tb02123 { get; set; }
        public virtual ICollection<Tb02124> Tb02124 { get; set; }
        public virtual ICollection<Tb02125> Tb02125 { get; set; }
        public virtual ICollection<Tb02219> Tb02219 { get; set; }
    }
}