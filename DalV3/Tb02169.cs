using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02169
    {
        public string Tb02169Codigo { get; set; }
        public string Tb02169Produto { get; set; }
        public int Tb02169Id { get; set; }
        public string Tb02169Codserv { get; set; }

        public virtual Tb01086 Tb02169CodservNavigation { get; set; }
        public virtual Tb02168 Tb02169Navigation { get; set; }
    }
}