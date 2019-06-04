using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DalUnlocker
{
    public partial class Tb07003Administrador
    {
      
        [Key]
        public int AdministradorId { get; set; }
        public int PerfilId { get; set; }
        [Required]
        [StringLength(200)]
        public string AdministradorNome { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string AdministradorEmail { get; set; }
        [StringLength(100)]
        [DataType(DataType.Password)]
        [Required]
        public string  AdministradorSenha { get; set; }
        public DateTime? AdministradorDataCreate { get; set; }
        public DateTime? AdministradorDataUpdate { get; set; }
        public DateTime? AdministradorDataDelete { get; set; }

        public virtual Tb07001Perfil  Tb07001Perfil { get; set; }
    }
}
