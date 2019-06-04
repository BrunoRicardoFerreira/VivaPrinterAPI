using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02190
    {
        public Tb02190()
        {
            Tb01106 = new HashSet<Tb01106>();
            Tb02192 = new HashSet<Tb02192>();
            Tb02193 = new HashSet<Tb02193>();
        }

        public DateTime? Tb02190Dtcad { get; set; }
        public string Tb02190Opcad { get; set; }
        public DateTime? Tb02190Dtalt { get; set; }
        public string Tb02190Opalt { get; set; }
        public string Tb02190Codigo { get; set; }
        public string Tb02190Contrato { get; set; }
        public string Tb02190Nome { get; set; }
        public string Tb02190Codserv { get; set; }
        public decimal? Tb02190Valor { get; set; }
        public string Tb02190Obs { get; set; }
        public string Tb02190Codcli { get; set; }
        public string Tb02190Codemp { get; set; }
        public DateTime? Tb02190Data { get; set; }
        public int? Tb02190Diafat { get; set; }
        public int? Tb02190Diavenc { get; set; }
        public string Tb02190Situacao { get; set; }
        public DateTime? Tb02190Dtencerra { get; set; }
        public string Tb02190Retpis { get; set; }
        public decimal? Tb02190Aliqpis { get; set; }
        public string Tb02190Retcofins { get; set; }
        public decimal? Tb02190Aliqcofins { get; set; }
        public string Tb02190Retcsll { get; set; }
        public decimal? Tb02190Aliqcsll { get; set; }
        public string Tb02190Retir { get; set; }
        public decimal? Tb02190Aliqir { get; set; }
        public string Tb02190Retiss { get; set; }
        public decimal? Tb02190Aliqiss { get; set; }
        public string Tb02190Retinss { get; set; }
        public int? Tb02190Qtcopias { get; set; }
        public int? Tb02190Qtcopias2 { get; set; }
        public decimal? Tb02190Valor2 { get; set; }
        public DateTime? Tb02190Dtvenc { get; set; }

        public virtual Tb01008 Tb02190CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02190CodempNavigation { get; set; }
        public virtual Tb01005 Tb02190CodservNavigation { get; set; }
        public virtual ICollection<Tb01106> Tb01106 { get; set; }
        public virtual ICollection<Tb02192> Tb02192 { get; set; }
        public virtual ICollection<Tb02193> Tb02193 { get; set; }
    }
}