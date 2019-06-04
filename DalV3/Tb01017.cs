using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01017
    {
        public Tb01017()
        {
            Tb02088 = new HashSet<Tb02088>();
            Tb02112 = new HashSet<Tb02112>();
            Tb02115 = new HashSet<Tb02115>();
            Tb04014 = new HashSet<Tb04014>();
            Tb04031 = new HashSet<Tb04031>();
            Tb04036 = new HashSet<Tb04036>();
        }

        public DateTime? Tb01017Dtcad { get; set; }
        public string Tb01017Opcad { get; set; }
        public DateTime? Tb01017Dtalt { get; set; }
        public string Tb01017Opalt { get; set; }
        public string Tb01017Cnpj { get; set; }
        public string Tb01017Codigo { get; set; }
        public string Tb01017Cpf { get; set; }
        public int? Tb01017Diasentrega { get; set; }
        public string Tb01017Fantasia { get; set; }
        public string Tb01017Ident { get; set; }
        public string Tb01017Inativo { get; set; }
        public string Tb01017Inscest { get; set; }
        public string Tb01017Inscmun { get; set; }
        public string Tb01017Nome { get; set; }
        public string Tb01017Obs { get; set; }
        public string Tb01017Pessoa { get; set; }
        public string Tb01017Ramo { get; set; }
        public string Tb01017Codcen { get; set; }
        public string Tb01017Codsub { get; set; }
        public string Tb01017Plancon { get; set; }

        public virtual Tb04004 Tb01017CodcenNavigation { get; set; }
        public virtual Tb04005 Tb01017CodsubNavigation { get; set; }
        public virtual Tb04006 Tb01017PlanconNavigation { get; set; }
        public virtual Tb01016 Tb01017RamoNavigation { get; set; }
        public virtual ICollection<Tb02088> Tb02088 { get; set; }
        public virtual ICollection<Tb02112> Tb02112 { get; set; }
        public virtual ICollection<Tb02115> Tb02115 { get; set; }
        public virtual ICollection<Tb04014> Tb04014 { get; set; }
        public virtual ICollection<Tb04031> Tb04031 { get; set; }
        public virtual ICollection<Tb04036> Tb04036 { get; set; }
    }
}