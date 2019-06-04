using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02176
    {
        public Tb02176()
        {
            Tb02018 = new HashSet<Tb02018>();
            Tb02021 = new HashSet<Tb02021>();
            Tb02204 = new HashSet<Tb02204>();
            Tb02227 = new HashSet<Tb02227>();
        }

        public DateTime? Tb02176Dtcad { get; set; }
        public string Tb02176Opcad { get; set; }
        public DateTime? Tb02176Dtalt { get; set; }
        public string Tb02176Opalt { get; set; }
        public string Tb02176Codigo { get; set; }
        public string Tb02176Codcli { get; set; }
        public string Tb02176Contrato { get; set; }
        public int? Tb02176Id { get; set; }
        public string Tb02176Nome { get; set; }
        public string Tb02176End { get; set; }
        public int? Tb02176Num { get; set; }
        public string Tb02176Bairro { get; set; }
        public string Tb02176Cidade { get; set; }
        public string Tb02176Estado { get; set; }
        public string Tb02176Cep { get; set; }
        public string Tb02176Contato { get; set; }
        public string Tb02176Email { get; set; }
        public string Tb02176Fone { get; set; }
        public string Tb02176Comp { get; set; }
        public int? Tb02176Estoque { get; set; }
        public string Tb02176Integra { get; set; }
        public string Tb02176Veiculo { get; set; }
        public string Tb02176Codemp { get; set; }

        public virtual ICollection<Tb02018> Tb02018 { get; set; }
        public virtual ICollection<Tb02021> Tb02021 { get; set; }
        public virtual ICollection<Tb02204> Tb02204 { get; set; }
        public virtual ICollection<Tb02227> Tb02227 { get; set; }
    }
}