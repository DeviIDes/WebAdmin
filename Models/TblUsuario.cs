using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdUsuario { get; set; }
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [Display(Name = "ApellidoMaterno")]
        public string ApellidoMaterno { get; set; }
        [Display(Name = "Nombre Usuario")]
        public string NombreUsuario { get; set; }
        [ForeignKey("TblCorporativo")]
        public Guid IdCorporativo { get; set; }
        [Display(Name = "Nombre Empresa")]
        public string NombreEmpresa { get; set; }
        [Display(Name = "Area")]
        public int IdArea { get; set; }
        [Display(Name = "Genero")]
        public int IdGenero { get; set; }
        [Display(Name = "Perfil")]
        public int IdPerfil { get; set; }
        [Display(Name = "Rol")]
        public int IdRol { get; set; }
        [Column("Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Correo de Acceso")]
        
        public string CorreoAcceso { get; set; }

          [Display(Name = "Profile Picture")]
    public byte[] ImagenPErfil { get; set; }
    [Display(Name = "Usuario")]
        public Guid IdUsuarioModifico { get; set; }
        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }



    }
}
