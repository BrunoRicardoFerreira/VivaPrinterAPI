using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01105
    {
        public Tb01105()
        {
            Tb02195 = new HashSet<Tb02195>();
        }

        public DateTime? Tb01105Dtcad { get; set; }
        public string Tb01105Opcad { get; set; }
        public DateTime? Tb01105Dtalt { get; set; }
        public string Tb01105Opalt { get; set; }
        public string Tb01105Codigo { get; set; }
        public string Tb01105Codcli { get; set; }
        public string Tb01105Nome { get; set; }
        public string Tb01105Situacao { get; set; }
        public string Tb01105End { get; set; }
        public string Tb01105Comp { get; set; }
        public int? Tb01105Num { get; set; }
        public string Tb01105Bairro { get; set; }
        public string Tb01105Cidade { get; set; }
        public string Tb01105Estado { get; set; }
        public string Tb01105Pais { get; set; }
        public string Tb01105Cep { get; set; }
        public string Tb01105Fone { get; set; }
        public string Tb01105Foneaux { get; set; }
        public string Tb01105Fax { get; set; }
        public string Tb01105Celular { get; set; }
        public string Tb01105Celular2 { get; set; }
        public string Tb01105Contato { get; set; }
        public string Tb01105Email { get; set; }
        public string Tb01105Site { get; set; }
        public string Tb01105Msn { get; set; }

        public virtual Tb01008 Tb01105CodcliNavigation { get; set; }
        public virtual ICollection<Tb02195> Tb02195 { get; set; }
    }
}