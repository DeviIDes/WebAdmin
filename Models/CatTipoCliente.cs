using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAdmin.Models
{
    public class CatTipoCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoCliente { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo Requerido")]
        public string TipoClienteDesc { get; set; }

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