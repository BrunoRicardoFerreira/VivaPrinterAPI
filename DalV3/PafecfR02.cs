using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class PafecfR02
    {
        public string R02Tipo { get; set; }
        public string R02Fabricacao { get; set; }
        public string R02Mf { get; set; }
        public string R02Modeloecf { get; set; }
        public string R02Usuario { get; set; }
        public string R02Crz { get; set; }
        public string R02Coo { get; set; }
        public string R02Cro { get; set; }
        public DateTime R02Data { get; set; }
        public DateTime? R02Dtemissao { get; set; }
        public string R02Hremissao { get; set; }
        public decimal? R02Vendabruta { get; set; }
        public string R02Issqn { get; set; }
        public string R02Alt { get; set; }
        public string R02Codemp { get; set; }
    }
}