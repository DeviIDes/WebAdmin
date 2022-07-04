using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class CatCategoria
    {
        public CatCategoria()
        {
            CatProductos = new HashSet<CatProducto>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoria { get; set; }
        [Display(Name = "Categoria")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo Requerido")]
        public string CategoriaDesc { get; set; }
        
[Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }
        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }
        [Display(Name = "Estatus")]

        public int IdEstatusRegistro { get; set; }
        public virtual ICollection<CatProducto> CatProductos { get; set; }
    }
}
