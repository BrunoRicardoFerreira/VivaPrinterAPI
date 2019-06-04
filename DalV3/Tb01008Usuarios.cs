using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DalUnlocker
{
    public partial class Tb01008Usuarios
    {
        public int UsuarioId { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioPassword { get; set; }
        public bool? UsuarioStatus { get; set; }
        public DateTime? UsuarioDataCreate { get; set; }
        public DateTime? UsuarioDataUpdate { get; set; }
        public DateTime? UsuarioDataDelete { get; set; }
        public string Tb01008Codigo { get; set; }

        public virtual Tb01008 Tb01008CodigoNavigation { get; set; }
    }
}