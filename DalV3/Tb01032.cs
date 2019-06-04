using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01032
    {
        public DateTime? Tb01032Dtcad { get; set; }
        public string Tb01032Opcad { get; set; }
        public DateTime? Tb01032Dtalt { get; set; }
        public string Tb01032Opalt { get; set; }
        public string Tb01032Codigo { get; set; }
        public DateTime? Tb01032Data { get; set; }
        public decimal? Tb01032Indice { get; set; }
        public string Tb01032Locacao { get; set; }
        public string Tb01032Nome { get; set; }
        public string Tb01032Situacao { get; set; }
        public string Tb01032Responsavel { get; set; }
        public decimal? Tb01032Vlrbem { get; set; }
        public string Tb01032Locadopara { get; set; }
        public decimal? Tb01032Vlrlocacao { get; set; }
        public string Tb01032Setor { get; set; }
        public int? Tb01032Qtde { get; set; }
        public string Tb01032Codemp { get; set; }
        public string Tb01032Codfor { get; set; }
        public int? Tb01032Mesdeprec { get; set; }
        public string Tb01032Ntfisc { get; set; }
        public string Tb01032Numserie { get; set; }
        public string Tb01032Obs { get; set; }

        public virtual Tb01001 Tb01032CodforNavigation { get; set; }
    }
}