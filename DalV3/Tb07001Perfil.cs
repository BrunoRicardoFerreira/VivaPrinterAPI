using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DalUnlocker
{

    public partial class Tb07001Perfil
    {
        public Tb07001Perfil()
        {
            Tb07002Permissoes = new HashSet<Tb07002Permissoes>();
            Tb07003Administrador = new HashSet<Tb07003Administrador>();
        }
        [Key]
        public int PerfilId { get; set; }
        [StringLength(200)]
        public string PerfilNome { get; set; }
        public bool  PerfilStatus { get; set; }
        public DateTime? PerfilDataCreate { get; set; }
        public DateTime? PerfilDataUpdate { get; set; }
        public DateTime? PerfilDataDelete { get; set; }

        public virtual ICollection<Tb07002Permissoes> Tb07002Permissoes { get; set; }
        public virtual ICollection<Tb07003Administrador> Tb07003Administrador { get; set; }

    }
}
