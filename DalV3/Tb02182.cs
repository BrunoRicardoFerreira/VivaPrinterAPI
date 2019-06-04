using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02182
    {
        public Tb02182()
        {
            Tb02018 = new HashSet<Tb02018>();
            Tb02021 = new HashSet<Tb02021>();
            Tb02227 = new HashSet<Tb02227>();
        }

        public DateTime? Tb02182Dtcad { get; set; }
        public string Tb02182Opcad { get; set; }
        public DateTime? Tb02182Dtalt { get; set; }
        public string Tb02182Opalt { get; set; }
        public string Tb02182Codigo { get; set; }
        public string Tb02182Nome { get; set; }
        public string Tb02182Codcli { get; set; }
        public string Tb02182Condpag { get; set; }
        public decimal? Tb02182Valor { get; set; }
        public int? Tb02182Horasfec { get; set; }
        public int? Tb02182Horasusada { get; set; }
        public int? Tb02182Horasresta { get; set; }
        public string Tb02182Horasfec2 { get; set; }
        public string Tb02182Horasusada2 { get; set; }
        public string Tb02182Horasresta2 { get; set; }
        public string Tb02182Codemp { get; set; }
        public string Tb02182Obs { get; set; }
        public string Tb02182Pedido { get; set; }
        public int? Tb02182Operacao { get; set; }
        public DateTime? Tb02182Data { get; set; }
        public DateTime? Tb02182Dataexec { get; set; }
        public string Tb02182Situacao { get; set; }

        public virtual Tb01008 Tb02182CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02182CodempNavigation { get; set; }
        public virtual Tb01014 Tb02182CondpagNavigation { get; set; }
        public virtual ICollection<Tb02018> Tb02018 { get; set; }
        public virtual ICollection<Tb02021> Tb02021 { get; set; }
        public virtual ICollection<Tb02227> Tb02227 { get; set; }
    }
}