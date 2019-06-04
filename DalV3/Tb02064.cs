using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02064
    {
        public int Tb02064Cotacao { get; set; }
        public string Tb02064Produto { get; set; }
        public string Tb02064Selec { get; set; }
        public string Tb02064Referencia { get; set; }
        public string Tb02064Codbarras { get; set; }
        public string Tb02064Nome { get; set; }
        public decimal? Tb02064Custo { get; set; }
        public decimal? Tb02064Customed { get; set; }
        public decimal? Tb02064Estoque { get; set; }
        public decimal? Tb02064Estmin { get; set; }
        public decimal? Tb02064Qtprod { get; set; }
        public decimal? Tb02064Venda { get; set; }
        public decimal? Tb02064Qtdemin { get; set; }
        public decimal? Tb02064Totvendas { get; set; }
        public decimal? Tb02064Mediavendas { get; set; }
        public decimal? Tb02064EstoqueI { get; set; }
        public decimal? Tb02064Reserva { get; set; }
        public decimal? Tb02064ReservaI { get; set; }
        public decimal? Tb02064Disponivel { get; set; }
        public decimal? Tb02064DisponivelI { get; set; }
        public decimal? Tb02064Estseg { get; set; }
        public decimal? Tb02064Contabil { get; set; }
        public decimal? Tb02064ContabilI { get; set; }
        public decimal? Tb02064Ped { get; set; }
        public string Tb02064Codauxiliar { get; set; }

        public virtual Tb02063 Tb02064CotacaoNavigation { get; set; }
        public virtual Tb01010 Tb02064ProdutoNavigation { get; set; }
    }
}