using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04003
    {
        public Tb04003()
        {
            Tb04009 = new HashSet<Tb04009>();
            Tb04010 = new HashSet<Tb04010>();
            Tb04034 = new HashSet<Tb04034>();
        }

        public DateTime? Tb04003Dtcad { get; set; }
        public string Tb04003Opcad { get; set; }
        public DateTime? Tb04003Dtalt { get; set; }
        public string Tb04003Opalt { get; set; }
        public string Tb04003Codigo { get; set; }
        public string Tb04003Nome { get; set; }
        public string Tb04003Situacao { get; set; }
        public string Tb04003Baixar { get; set; }
        public string Tb04003Limitecredito { get; set; }
        public string Tb04003Duvidoso { get; set; }
        public string Tb04003Pendencia { get; set; }
        public string Tb04003Datashop { get; set; }
        public string Tb04003Tef { get; set; }
        public string Tb04003Pedirqt { get; set; }
        public string Tb04003Pedirvenc { get; set; }
        public string Tb04003Boleto { get; set; }
        public int? Tb04003NumeroDias { get; set; }
        public string Tb04003Codnfce { get; set; }
        public string Tb04003Plancon { get; set; }

        public virtual Tb04006 Tb04003PlanconNavigation { get; set; }
        public virtual ICollection<Tb04009> Tb04009 { get; set; }
        public virtual ICollection<Tb04010> Tb04010 { get; set; }
        public virtual ICollection<Tb04034> Tb04034 { get; set; }
    }
}