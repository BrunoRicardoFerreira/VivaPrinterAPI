using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02112
    {
        public Tb02112()
        {
            Tb02113 = new HashSet<Tb02113>();
            Tb02114 = new HashSet<Tb02114>();
            Tb02127 = new HashSet<Tb02127>();
            Tb02128 = new HashSet<Tb02128>();
            Tb02156 = new HashSet<Tb02156>();
        }

        public DateTime? Tb02112Dtcad { get; set; }
        public string Tb02112Opcad { get; set; }
        public DateTime? Tb02112Dtalt { get; set; }
        public string Tb02112Opalt { get; set; }
        public string Tb02112Codigo { get; set; }
        public string Tb02112Produto { get; set; }
        public string Tb02112Numserie { get; set; }
        public DateTime? Tb02112Data { get; set; }
        public string Tb02112End { get; set; }
        public int? Tb02112Num { get; set; }
        public string Tb02112Comp { get; set; }
        public string Tb02112Bairro { get; set; }
        public string Tb02112Cidade { get; set; }
        public string Tb02112Estado { get; set; }
        public string Tb02112Cep { get; set; }
        public string Tb02112Fone { get; set; }
        public string Tb02112Foneaux { get; set; }
        public string Tb02112Fax { get; set; }
        public string Tb02112Contato { get; set; }
        public string Tb02112Email { get; set; }
        public int? Tb02112Tipointerv { get; set; }
        public int? Tb02112Horas { get; set; }
        public int? Tb02112Tipohoras { get; set; }
        public string Tb02112Codtec { get; set; }
        public string Tb02112Prest { get; set; }
        public string Tb02112Obs { get; set; }
        public string Tb02112Novo { get; set; }
        public string Tb02112Vend { get; set; }
        public string Tb02112Tipodesc { get; set; }
        public string Tb02112Condpag { get; set; }
        public string Tb02112Status { get; set; }
        public string Tb02112Codvenda { get; set; }
        public string Tb02112Situacao { get; set; }
        public DateTime? Tb02112Dtinativo { get; set; }
        public string Tb02112Local { get; set; }
        public string Tb02112Ibtracker1 { get; set; }
        public string Tb02112Ibtracker2 { get; set; }
        public decimal? Tb02112Custo { get; set; }
        public string Tb02112Pat { get; set; }
        public int? Tb02112Franqpb { get; set; }
        public int? Tb02112Franqcolor { get; set; }
        public int? Tb02112Franqtotal { get; set; }
        public int? Tb02112Franqdg { get; set; }
        public int? Tb02112Franqgf { get; set; }
        public string Tb02112Netname { get; set; }
        public string Tb02112Ip { get; set; }
        public string Tb02112Orig { get; set; }
        public string Tb02112Tipoequip { get; set; }
        public int? Tb02112Nddid { get; set; }
        public int? Tb02112Nddsite { get; set; }
        public int? Tb02112Ndddepto { get; set; }
        public string Tb02112Etiqserv { get; set; }
        public int? Tb02112Franqgfc { get; set; }
        public int? Tb02112Horaspapel { get; set; }
        public string Tb02112Modulo { get; set; }
        public int? Tb02112Horassup { get; set; }
        public int? Tb02112Horasatende { get; set; }
        public int? Tb02112Tipoinstall { get; set; }
        public string Tb02112Grupo { get; set; }
        public string Tb02112Codsite { get; set; }
        public string Tb02112Coddepto { get; set; }

        public virtual Tb02111 Tb02112CodigoNavigation { get; set; }
        public virtual Tb01024 Tb02112CodtecNavigation { get; set; }
        public virtual Tb01014 Tb02112CondpagNavigation { get; set; }
        public virtual Tb00009 Tb02112ModuloNavigation { get; set; }
        public virtual Tb01017 Tb02112PrestNavigation { get; set; }
        public virtual Tb01010 Tb02112ProdutoNavigation { get; set; }
        public virtual Tb01021 Tb02112StatusNavigation { get; set; }
        public virtual Tb01022 Tb02112TipodescNavigation { get; set; }
        public virtual Tb01006 Tb02112VendNavigation { get; set; }
        public virtual ICollection<Tb02113> Tb02113 { get; set; }
        public virtual ICollection<Tb02114> Tb02114 { get; set; }
        public virtual ICollection<Tb02127> Tb02127 { get; set; }
        public virtual ICollection<Tb02128> Tb02128 { get; set; }
        public virtual ICollection<Tb02156> Tb02156 { get; set; }
    }
}