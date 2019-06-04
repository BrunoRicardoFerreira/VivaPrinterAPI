using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04043
    {
        public Tb04043()
        {
            Tb04044 = new HashSet<Tb04044>();
        }

        public int Tb04043Ret { get; set; }
        public string Tb04043Codemp { get; set; }
        public DateTime? Tb04043Data { get; set; }
        public string Tb04043Opcad { get; set; }
        public string Tb04043Codban { get; set; }
        public string Tb04043Codcon { get; set; }
        public string Tb04043Arqretorno { get; set; }
        public int? Tb04043Qtde { get; set; }
        public int? Tb04043Qtderec { get; set; }
        public int? Tb04043Qtdepend { get; set; }
        public decimal? Tb04043Vlrtotal { get; set; }
        public decimal? Tb04043Vlrrec { get; set; }
        public decimal? Tb04043Vlrpend { get; set; }
        public DateTime? Tb04043Dtprocessa { get; set; }
        public int? Tb04043Diasbaixa { get; set; }
        public string Tb04043Alter { get; set; }
        public string Tb04043Codcon2 { get; set; }

        public virtual Tb04008 Tb04043CodbanNavigation { get; set; }
        public virtual Tb04009 Tb04043CodconNavigation { get; set; }
        public virtual Tb01007 Tb04043CodempNavigation { get; set; }
        public virtual ICollection<Tb04044> Tb04044 { get; set; }
    }
}