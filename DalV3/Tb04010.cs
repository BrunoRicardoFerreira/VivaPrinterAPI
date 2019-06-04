using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04010
    {
        public Tb04010()
        {
            Tb04039 = new HashSet<Tb04039>();
            Tb04042 = new HashSet<Tb04042>();
        }

        public DateTime? Tb04010Dtcad { get; set; }
        public string Tb04010Opcad { get; set; }
        public DateTime? Tb04010Dtalt { get; set; }
        public string Tb04010Opalt { get; set; }
        public string Tb04010Codcen { get; set; }
        public string Tb04010Codcli { get; set; }
        public string Tb04010Codemp { get; set; }
        public string Tb04010Codigo { get; set; }
        public string Tb04010Codigo2 { get; set; }
        public string Tb04010Codsub { get; set; }
        public DateTime? Tb04010Data { get; set; }
        public DateTime? Tb04010Dtvenc { get; set; }
        public string Tb04010Nome { get; set; }
        public string Tb04010Obs { get; set; }
        public string Tb04010Situacao { get; set; }
        public string Tb04010Tipdoc { get; set; }
        public decimal? Tb04010Vlracres { get; set; }
        public decimal? Tb04010Vlrbruto { get; set; }
        public decimal? Tb04010Vlrdesconto { get; set; }
        public decimal? Tb04010Vlrtitulo { get; set; }
        public decimal? Tb04010Vlrpago { get; set; }
        public string Tb04010Parcial { get; set; }
        public string Tb04010Plancon { get; set; }
        public int? Tb04010Tipotitulo { get; set; }
        public int? Tb04010Statusrec { get; set; }
        public DateTime? Tb04010Dtconf { get; set; }
        public string Tb04010Opconf { get; set; }
        public string Tb04010Vend { get; set; }
        public string Tb04010Ntfisc { get; set; }
        public string Tb04010Mes { get; set; }
        public int? Tb04010Diasatraso { get; set; }
        public string Tb04010Contrato { get; set; }
        public DateTime? Tb04010Dtvencoriginal { get; set; }
        public decimal? Tb04010Vlrmov { get; set; }
        public string Tb04010Fantasia { get; set; }
        public string Tb04010Numproces { get; set; }
        public string Tb04010Serasa { get; set; }
        public string Tb04010Provisao { get; set; }
        public int? Tb04010Lote { get; set; }
        public string Tb04010Nomeemit { get; set; }
        public string Tb04010Numagen { get; set; }
        public string Tb04010Numcont { get; set; }
        public string Tb04010Numcheque { get; set; }
        public string Tb04010Telemit { get; set; }

        public virtual Tb04004 Tb04010CodcenNavigation { get; set; }
        public virtual Tb01008 Tb04010CodcliNavigation { get; set; }
        public virtual Tb01007 Tb04010CodempNavigation { get; set; }
        public virtual Tb04005 Tb04010CodsubNavigation { get; set; }
        public virtual Tb04006 Tb04010PlanconNavigation { get; set; }
        public virtual Tb04003 Tb04010TipdocNavigation { get; set; }
        public virtual Tb01006 Tb04010VendNavigation { get; set; }
        public virtual ICollection<Tb04039> Tb04039 { get; set; }
        public virtual ICollection<Tb04042> Tb04042 { get; set; }
    }
}