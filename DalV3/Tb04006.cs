using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04006
    {
        public Tb04006()
        {
            Tb01001 = new HashSet<Tb01001>();
            Tb01005 = new HashSet<Tb01005>();
            Tb01008 = new HashSet<Tb01008>();
            Tb01009 = new HashSet<Tb01009>();
            Tb01010 = new HashSet<Tb01010>();
            Tb01011 = new HashSet<Tb01011>();
            Tb01017 = new HashSet<Tb01017>();
            Tb01074 = new HashSet<Tb01074>();
            Tb02002 = new HashSet<Tb02002>();
            Tb02009 = new HashSet<Tb02009>();
            Tb02011 = new HashSet<Tb02011>();
            Tb02030 = new HashSet<Tb02030>();
            Tb02059 = new HashSet<Tb02059>();
            Tb02073 = new HashSet<Tb02073>();
            Tb02087 = new HashSet<Tb02087>();
            Tb02088 = new HashSet<Tb02088>();
            Tb02100 = new HashSet<Tb02100>();
            Tb04003 = new HashSet<Tb04003>();
            Tb04009 = new HashSet<Tb04009>();
            Tb04010 = new HashSet<Tb04010>();
            Tb04014 = new HashSet<Tb04014>();
            Tb04034 = new HashSet<Tb04034>();
            Tb04036 = new HashSet<Tb04036>();
            Tb04040 = new HashSet<Tb04040>();
            Tb04047 = new HashSet<Tb04047>();
            Tb04051 = new HashSet<Tb04051>();
        }

        public DateTime? Tb04006Dtcad { get; set; }
        public string Tb04006Opcad { get; set; }
        public DateTime? Tb04006Dtalt { get; set; }
        public string Tb04006Opalt { get; set; }
        public string Tb04006Codigo { get; set; }
        public string Tb04006Codigo1 { get; set; }
        public string Tb04006Codigo2 { get; set; }
        public string Tb04006Nome { get; set; }
        public int? Tb04006Nivel { get; set; }
        public string Tb04006Situacao { get; set; }
        public string Tb04006Codigo3 { get; set; }
        public string Tb04006Codigo4 { get; set; }
        public string Tb04006Codigo5 { get; set; }
        public string Tb04006Conta { get; set; }
        public string Tb04006Sped { get; set; }
        public string Tb04006Natureza { get; set; }
        public string Tb04006Tipoconta { get; set; }
        public string Tb04006CodNatConta { get; set; }
        public string Tb04006CodContaRef { get; set; }

        public virtual ICollection<Tb01001> Tb01001 { get; set; }
        public virtual ICollection<Tb01005> Tb01005 { get; set; }
        public virtual ICollection<Tb01008> Tb01008 { get; set; }
        public virtual ICollection<Tb01009> Tb01009 { get; set; }
        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb01011> Tb01011 { get; set; }
        public virtual ICollection<Tb01017> Tb01017 { get; set; }
        public virtual ICollection<Tb01074> Tb01074 { get; set; }
        public virtual ICollection<Tb02002> Tb02002 { get; set; }
        public virtual ICollection<Tb02009> Tb02009 { get; set; }
        public virtual ICollection<Tb02011> Tb02011 { get; set; }
        public virtual ICollection<Tb02030> Tb02030 { get; set; }
        public virtual ICollection<Tb02059> Tb02059 { get; set; }
        public virtual ICollection<Tb02073> Tb02073 { get; set; }
        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb02088> Tb02088 { get; set; }
        public virtual ICollection<Tb02100> Tb02100 { get; set; }
        public virtual ICollection<Tb04003> Tb04003 { get; set; }
        public virtual ICollection<Tb04009> Tb04009 { get; set; }
        public virtual ICollection<Tb04010> Tb04010 { get; set; }
        public virtual ICollection<Tb04014> Tb04014 { get; set; }
        public virtual ICollection<Tb04034> Tb04034 { get; set; }
        public virtual ICollection<Tb04036> Tb04036 { get; set; }
        public virtual ICollection<Tb04040> Tb04040 { get; set; }
        public virtual ICollection<Tb04047> Tb04047 { get; set; }
        public virtual ICollection<Tb04051> Tb04051 { get; set; }
    }
}