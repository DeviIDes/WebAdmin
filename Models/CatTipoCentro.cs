using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAdmin.Models
{
    public class CatTipoCentro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoCentro { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo Requerido")]
        public string TipoCentroDesc { get; set; }

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