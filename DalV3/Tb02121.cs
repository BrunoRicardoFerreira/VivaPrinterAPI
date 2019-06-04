using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02121
    {
        public DateTime? Tb02121Dtcad { get; set; }
        public string Tb02121Opcad { get; set; }
        public DateTime? Tb02121Dtalt { get; set; }
        public string Tb02121Opalt { get; set; }
        public string Tb02121Codigo { get; set; }
        public string Tb02121Contrato { get; set; }
        public string Tb02121Codcli { get; set; }
        public string Tb02121Produto { get; set; }
        public string Tb02121Numserie { get; set; }
        public DateTime? Tb02121Data { get; set; }
        public string Tb02121Codemp { get; set; }
        public string Tb02121Situacao { get; set; }
        public DateTime? Tb02121Datagera { get; set; }
        public string Tb02121Numos { get; set; }
        public string Tb02121Status { get; set; }

        public virtual Tb01008 Tb02121CodcliNavigation { get; set; }
    }
}