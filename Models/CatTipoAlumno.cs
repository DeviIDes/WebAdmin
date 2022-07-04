using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAdmin.Models
{
    public class CatTipoAlumno
    {

        public CatTipoAlumno()
        {
            TblUsuarios = new HashSet<TblUsuario>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoAlumno { get; set; }
        [Display(Name = "Descripción")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo Requerido")]
        public string TipoAlumnoDesc { get; set; }
        [Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }
        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }
        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }


        public virtual ICollection<TblUsuario> TblUsuarios { get; set; }
    }
}
