using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblClienteDireccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClienteDirecciones { get; set; }

        [ForeignKey("CatTipoDireccion")]
        [Display(Name = "Tipo Direccion")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdTipoDireccion { get; set; }

        [Display(Name = "Tipo Direccion")]
        [NotMapped]
        public string TipoDireccionDesc { get; set; }

        [Display(Name = "Calle")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string Calle { get; set; }

        [Display(Name = "Codigo Postal")]
        public string CodigoPostal { get; set; }

        public string IdColonia { get; set; }

        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Display(Name = "Localidad / Municipio")]
        public string LocalidadMunicipio { get; set; }

        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string CorreoElectronico { get; set; }

        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [ForeignKey("TblCliente")]
        [Display(Name = "Cliente")]
        public Guid IdCliente { get; set; }

        [NotMapped]
        [Display(Name = "Nombre Cliente")]
        public string NombreCliente { get; set; }

        [Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }

        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }
    }
}