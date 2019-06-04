using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02185
    {
        public Tb02185()
        {
            Tb02186 = new HashSet<Tb02186>();
            Tb02187 = new HashSet<Tb02187>();
        }

        public DateTime? Tb02185Dtcad { get; set; }
        public string Tb02185Opcad { get; set; }
        public DateTime? Tb02185Dtalt { get; set; }
        public string Tb02185Opalt { get; set; }
        public string Tb02185Codigo { get; set; }
        public string Tb02185Contrato { get; set; }
        public string Tb02185Nome { get; set; }
        public int? Tb02185Franqpb { get; set; }
        public int? Tb02185Franqcolor { get; set; }
        public int? Tb02185Franqdg { get; set; }
        public int? Tb02185Franqgf { get; set; }
        public int? Tb02185Franqgfc { get; set; }
        public string Tb02185Situacao { get; set; }
        public string Tb02185Color { get; set; }
        public int? Tb02185Qtequipamento { get; set; }
        public int? Tb02185Estimativapb { get; set; }
        public int? Tb02185Estimativacolor { get; set; }
        public int? Tb02185Estimativadg { get; set; }
        public int? Tb02185Estimativagf { get; set; }
        public int? Tb02185Estimativagfc { get; set; }
        public decimal? Tb02185Vlrnotapb { get; set; }
        public decimal? Tb02185Vlrnotacl { get; set; }
        public decimal? Tb02185Vlrnotadg { get; set; }
        public decimal? Tb02185Vlrnotagf { get; set; }
        public decimal? Tb02185Vlrnotagfc { get; set; }

        public virtual Tb02111 Tb02185ContratoNavigation { get; set; }
        public virtual ICollection<Tb02186> Tb02186 { get; set; }
        public virtual ICollection<Tb02187> Tb02187 { get; set; }
    }
}