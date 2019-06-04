using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01024
    {
        public Tb01024()
        {
            Tb01080 = new HashSet<Tb01080>();
            Tb02050 = new HashSet<Tb02050>();
            Tb02112 = new HashSet<Tb02112>();
            Tb02115 = new HashSet<Tb02115>();
            Tb02122 = new HashSet<Tb02122>();
            Tb02193 = new HashSet<Tb02193>();
            Tb02196 = new HashSet<Tb02196>();
            Tb02214 = new HashSet<Tb02214>();
        }

        public DateTime? Tb01024Dtcad { get; set; }
        public string Tb01024Opcad { get; set; }
        public DateTime? Tb01024Dtalt { get; set; }
        public string Tb01024Opalt { get; set; }
        public string Tb01024Ag { get; set; }
        public string Tb01024Banco { get; set; }
        public string Tb01024Classe { get; set; }
        public int? Tb01024Clientes { get; set; }
        public string Tb01024Codigo { get; set; }
        public decimal? Tb01024Comissao { get; set; }
        public string Tb01024Conta { get; set; }
        public string Tb01024Cpf { get; set; }
        public decimal? Tb01024Ctrec { get; set; }
        public decimal? Tb01024Ctaberto { get; set; }
        public DateTime? Tb01024Dtaniv { get; set; }
        public string Tb01024Ident { get; set; }
        public string Tb01024Nome { get; set; }
        public string Tb01024Obs { get; set; }
        public int? Tb01024Produtos { get; set; }
        public string Tb01024Situacao { get; set; }
        public int? Tb01024Vendas { get; set; }
        public decimal? Tb01024Vlrvendas { get; set; }
        public DateTime? Tb01024Ultvendas { get; set; }
        public string Tb01024Usuario { get; set; }
        public string Tb01024Senha { get; set; }
        public decimal? Tb01024Horatec { get; set; }
        public string Tb01024Territorio { get; set; }
        public string Tb01024Codtec { get; set; }
        public string Tb01024Nometec { get; set; }
        public string Tb01024Codfor { get; set; }

        public virtual ICollection<Tb01080> Tb01080 { get; set; }
        public virtual ICollection<Tb02050> Tb02050 { get; set; }
        public virtual ICollection<Tb02112> Tb02112 { get; set; }
        public virtual ICollection<Tb02115> Tb02115 { get; set; }
        public virtual ICollection<Tb02122> Tb02122 { get; set; }
        public virtual ICollection<Tb02193> Tb02193 { get; set; }
        public virtual ICollection<Tb02196> Tb02196 { get; set; }
        public virtual ICollection<Tb02214> Tb02214 { get; set; }
    }
}