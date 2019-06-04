using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01021
    {
        public Tb01021()
        {
            Tb01035 = new HashSet<Tb01035>();
            Tb01039 = new HashSet<Tb01039>();
            Tb01055Tb01055Status2Navigation = new HashSet<Tb01055>();
            Tb01055Tb01055StatusNavigation = new HashSet<Tb01055>();
            Tb01092Tb01092StatusautorizaNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatuscanntfiscNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusentregaNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusenvntfiscNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusexpedicaoNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusinicialNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusntfiscNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusresNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatusretornoNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatussaidaNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatustecNavigation = new HashSet<Tb01092>();
            Tb01092Tb01092StatustiraresNavigation = new HashSet<Tb01092>();
            Tb02112 = new HashSet<Tb02112>();
            Tb02122 = new HashSet<Tb02122>();
        }

        public DateTime? Tb01021Dtcad { get; set; }
        public string Tb01021Opcad { get; set; }
        public DateTime? Tb01021Dtalt { get; set; }
        public string Tb01021Opalt { get; set; }
        public string Tb01021Codigo { get; set; }
        public string Tb01021Nome { get; set; }
        public string Tb01021Situacao { get; set; }
        public string Tb01021Pedirsenha { get; set; }
        public string Tb01021Color { get; set; }
        public string Tb01021Senha { get; set; }
        public string Tb01021Pedirsenha2 { get; set; }
        public string Tb01021Color2 { get; set; }
        public string Tb01021Senha2 { get; set; }
        public string Tb01021Imprimir { get; set; }
        public string Tb01021Nautoriza { get; set; }
        public string Tb01021Nreserva { get; set; }
        public string Tb01021Retres { get; set; }
        public string Tb01021Obrres { get; set; }
        public int? Tb01021Tipostatus { get; set; }
        public string Tb01021Tecnico { get; set; }
        public string Tb01021Email { get; set; }
        public string Tb01021Altprevisao { get; set; }
        public int? Tb01021Previsao { get; set; }
        public string Tb01021Serie { get; set; }
        public string Tb01021Semprev { get; set; }
        public string Tb01021Dataservice { get; set; }
        public string Tb01021Reincidencia { get; set; }
        public string Tb01021Inicial { get; set; }
        public string Tb01021Entstatus { get; set; }
        public int? Tb01021Tiporomaneio { get; set; }
        public string Tb01021Susporc { get; set; }
        public string Tb01021Geraos { get; set; }
        public string Tb01021Statusos { get; set; }
        public int? Tb01021Sla { get; set; }
        public int? Tb01021Tiposla { get; set; }
        public int? Tb01021Tipoexec { get; set; }
        public string Tb01021Altmodulo { get; set; }
        public string Tb01021Altclass { get; set; }
        public string Tb01021Altprioridade { get; set; }
        public string Tb01021Monitor { get; set; }
        public string Tb01021Altexecucao { get; set; }
        public string Tb01021Repllaudo { get; set; }
        public string Tb01021Replhora { get; set; }
        public string Tb01021Descdataservice { get; set; }

        public virtual Tb01073 Tb01021StatusosNavigation { get; set; }
        public virtual ICollection<Tb01035> Tb01035 { get; set; }
        public virtual ICollection<Tb01039> Tb01039 { get; set; }
        public virtual ICollection<Tb01055> Tb01055Tb01055Status2Navigation { get; set; }
        public virtual ICollection<Tb01055> Tb01055Tb01055StatusNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusautorizaNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatuscanntfiscNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusentregaNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusenvntfiscNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusexpedicaoNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusinicialNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusntfiscNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusresNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatusretornoNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatussaidaNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatustecNavigation { get; set; }
        public virtual ICollection<Tb01092> Tb01092Tb01092StatustiraresNavigation { get; set; }
        public virtual ICollection<Tb02112> Tb02112 { get; set; }
        public virtual ICollection<Tb02122> Tb02122 { get; set; }
    }
}