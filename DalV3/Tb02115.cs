using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02115
    {
        public Tb02115()
        {
            Tb02116 = new HashSet<Tb02116>();
        }

        public DateTime? Tb02115Dtcad { get; set; }
        public string Tb02115Opcad { get; set; }
        public DateTime? Tb02115Dtalt { get; set; }
        public string Tb02115Opalt { get; set; }
        public string Tb02115Codigo { get; set; }
        public string Tb02115Contrato { get; set; }
        public string Tb02115Codcli { get; set; }
        public string Tb02115Produto { get; set; }
        public string Tb02115Numserie { get; set; }
        public DateTime? Tb02115Data { get; set; }
        public string Tb02115Atendente { get; set; }
        public string Tb02115Solicitante { get; set; }
        public string Tb02115Codemp { get; set; }
        public string Tb02115Situacao { get; set; }
        public string Tb02115Nome { get; set; }
        public string Tb02115Preventiva { get; set; }
        public string Tb02115Obs { get; set; }
        public DateTime? Tb02115Dtfecha { get; set; }
        public string Tb02115Reincidencia { get; set; }
        public string Tb02115Os { get; set; }
        public string Tb02115Origem { get; set; }
        public string Tb02115Codtec { get; set; }
        public string Tb02115Prest { get; set; }
        public string Tb02115Tipointerv { get; set; }
        public string Tb02115Status { get; set; }
        public string Concluido { get; set; }
        public int? Tb02115Ordem { get; set; }
        public int? Tb02115Contpb { get; set; }
        public int? Tb02115Contcolor { get; set; }
        public int? Tb02115Conttotal { get; set; }
        public string Tb02115Pedido { get; set; }
        public int? Tb02115Slafim { get; set; }
        public string Tb02115End { get; set; }
        public int? Tb02115Num { get; set; }
        public string Tb02115Comp { get; set; }
        public string Tb02115Bairro { get; set; }
        public string Tb02115Cidade { get; set; }
        public string Tb02115Estado { get; set; }
        public string Tb02115Cep { get; set; }
        public string Tb02115Fone { get; set; }
        public string Tb02115Fone2 { get; set; }
        public string Tb02115Celular { get; set; }
        public string Tb02115Email { get; set; }
        public string Tb02115Codsite { get; set; }
        public string Tb02115Coddepto { get; set; }
        public string Tb02115Contato { get; set; }
        public string Tb02115Local { get; set; }

        public virtual Tb01008 Tb02115CodcliNavigation { get; set; }
        public virtual Tb01024 Tb02115CodtecNavigation { get; set; }
        public virtual Tb01017 Tb02115PrestNavigation { get; set; }
        public virtual Tb01073 Tb02115StatusNavigation { get; set; }
        public virtual Tb02122 Tb02122 { get; set; }
        public virtual ICollection<Tb02116> Tb02116 { get; set; }
    }
}