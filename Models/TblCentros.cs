using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblCentros
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCentro { get; set; }
        [Display(Name = "Centro")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string NombreCentro { get; set; }
       
        [Display(Name = "Calle")]

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
        public Guid IdEmpresa { get; set; }
        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }
        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }
 

  
    }
}
