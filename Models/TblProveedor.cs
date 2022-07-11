using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblProveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdProveedor { get; set; }

        [Display(Name = "Nombre Proveedor")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string NombreProveedor { get; set; }

        [Display(Name = "RFC")]
        public string Rfc { get; set; }

        [Display(Name = "Giro Comercial")]
        public string GiroComercial { get; set; }

        [ForeignKey("TblCorporativo")]
        public Guid IdCorporativo { get; set; }

        [Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }

        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdEstatusRegistro { get; set; }
    }
}