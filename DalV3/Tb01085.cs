using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01085
    {
        public Tb01085()
        {
            Tb02166 = new HashSet<Tb02166>();
        }

        public DateTime? Tb01085Dtcad { get; set; }
        public string Tb01085Opcad { get; set; }
        public DateTime? Tb01085Dtalt { get; set; }
        public string Tb01085Opalt { get; set; }
        public string Tb01085Codigo { get; set; }
        public string Tb01085Nome { get; set; }
        public string Tb01085Situacao { get; set; }
        public string Tb01085Inicial { get; set; }
        public string Tb01085Color { get; set; }
        public string Tb01085Color2 { get; set; }
        public string Tb01085Pedirsenha { get; set; }
        public string Tb01085Pedirsenha2 { get; set; }
        public string Tb01085Senha { get; set; }
        public string Tb01085Senha2 { get; set; }
        public string Tb01085Receber { get; set; }
        public string Tb01085Laudo { get; set; }
        public string Tb01085Faturar { get; set; }
        public string Tb01085Concluir { get; set; }

        public virtual ICollection<Tb02166> Tb02166 { get; set; }
    }
}