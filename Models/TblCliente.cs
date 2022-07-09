using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblCliente
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCliente { get; set; }

        [Display(Name = "Tipo Cliente")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdTipoCliente { get; set; }

        [Display(Name = "Nombre Cliente")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string NombreCliente { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "ApellidoMaterno")]
        public string ApellidoMaterno { get; set; }

        [Display(Name = "Perfil")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdPerfil { get; set; }

        [Display(Name = "Rol")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdRol { get; set; }

        [Display(Name = "Correo Electronico")]

        public string CorreoAcceso { get; set; }

        [Display(Name = "Clave Acceso")]

        public string ClaveAcceso { get; set; }

        [Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }

        [Display(Name = "Corporativo / Centro")]
        public Guid IdUCorporativoCentro { get; set; }
        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        [Column("FechaAcceso")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Acceso")]
        public DateTime FechaAcceso { get; set; }

        [NotMapped]
        public string ReturnUrl { get; set; }

        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }

         [Display(Name = "Nombre Completo")]
        public string FullName
        {
            get
            {
                return NombreCliente + ", " + ApellidoMaterno + " " + ApellidoMaterno;
            }
        }
    }
}