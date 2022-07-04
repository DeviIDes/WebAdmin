using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblEmpresa
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdEmpresa { get; set; }
        [Display(Name = "Nombre Empresa")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string NombreEmpresa { get; set; }
        [Display(Name = "RFC")]

        public string Rfc { get; set; }
        [Display(Name = "Giro Comercial")]

        public string GiroComercial { get; set; }
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
        [Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }

         [NotMapped]
        public string FiltroUserName { get; set; }
        [Column("FechaRegistro")]
        [DataType(DataType.Date)]

        public DateTime FechaRegistro { get; set; }
        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }

        public TblEmpresa()
        {
            TblCorporativos = new HashSet<TblCorporativo>();

        }

        public virtual ICollection<TblCorporativo> TblCorporativos { get; set; }


    }
}
