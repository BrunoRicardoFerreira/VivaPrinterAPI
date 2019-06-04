using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01073
    {
        public Tb01073()
        {
            Tb01021 = new HashSet<Tb01021>();
            Tb01039 = new HashSet<Tb01039>();
            Tb01055 = new HashSet<Tb01055>();
            Tb02115 = new HashSet<Tb02115>();
        }

        public DateTime? Tb01073Dtcad { get; set; }
        public string Tb01073Opcad { get; set; }
        public DateTime? Tb01073Dtalt { get; set; }
        public string Tb01073Opalt { get; set; }
        public string Tb01073Codigo { get; set; }
        public string Tb01073Concluir { get; set; }
        public string Tb01073Pendente { get; set; }
        public string Tb01073Trocada { get; set; }
        public string Tb01073Inicial { get; set; }
        public string Tb01073Sla { get; set; }
        public string Tb01073Nome { get; set; }
        public string Tb01073Tecnico { get; set; }
        public string Tb01073Color { get; set; }
        public string Tb01073Color2 { get; set; }
        public string Tb01073Situacao { get; set; }
        public string Tb01073Email { get; set; }
        public string Tb01073Osnfech { get; set; }
        public string Tb01073Normal { get; set; }
        public string Tb01073Preventiva { get; set; }
        public string Tb01073Instalacao { get; set; }
        public string Tb01073Desinstalacao { get; set; }
        public string Tb01073Recarga { get; set; }
        public string Tb01073Osfechada { get; set; }
        public string Tb01073Afericao { get; set; }
        public string Tb01073Dataservice { get; set; }
        public string Tb01073Descdataservice { get; set; }

        public virtual ICollection<Tb01021> Tb01021 { get; set; }
        public virtual ICollection<Tb01039> Tb01039 { get; set; }
        public virtual ICollection<Tb01055> Tb01055 { get; set; }
        public virtual ICollection<Tb02115> Tb02115 { get; set; }
    }
}