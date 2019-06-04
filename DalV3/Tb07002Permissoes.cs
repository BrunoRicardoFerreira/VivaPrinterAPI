using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DalUnlocker
{
    public partial class Tb07002Permissoes
    {

        [Key]
        public int PermissoesId { get; set; }
        public int PerfilId { get; set; }
        public int MenuId { get; set; }
        public bool PermissoesListar { get; set; }
        public bool PermissoesCriar { get; set; }
        public bool PermissoesAtualizar { get; set; }
        public bool PermissoesDelete { get; set; }

        public virtual Tb07001Perfil Tb07001Perfil { get; set; }

    }
}
