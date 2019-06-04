using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02085
    {
        public int Tb02085Codigo { get; set; }
        public int Tb02085Num { get; set; }
        public string Tb02085Tipo { get; set; }
        public string Tb02085Mes { get; set; }

        public virtual Tb02083 Tb02085CodigoNavigation { get; set; }
    }
}