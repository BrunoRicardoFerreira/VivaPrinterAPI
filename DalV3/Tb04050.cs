using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04050
    {
        public string Tb04050Codemp { get; set; }
        public string Tb04050Codfor { get; set; }
        public string Tb04050Transp { get; set; }
        public string Tb04050Prest { get; set; }
        public string Tb04050Codigo { get; set; }
        public int Tb04050Operacao { get; set; }
        public DateTime Tb04050Data { get; set; }
        public string Tb04050Status { get; set; }
        public string Tb04050User { get; set; }
        public string Tb04050Obs { get; set; }

        public virtual Tb01102 Tb04050StatusNavigation { get; set; }
    }
}