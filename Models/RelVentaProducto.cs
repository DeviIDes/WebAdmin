using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAdmin.Models
{
    public class RelVentaProducto
    {
         [Display(Name = "ID Ventas Productos")]
        [Key]
        public Guid IdRelVentaProducto { get; set; }
[Display(Name = "ID Categoria")] 
        public int IdCategoria { get; set; }
        [Display(Name = "ID Producto")] 
        public int IdProducto { get; set; }

[Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio")]
        public decimal ProductoPrecioUno { get; set; }

        [Display(Name = "ID Cotización")]

        public Guid IdVenta { get; set; }
        
        [Display(Name = "Usuario")]
        public Guid IdUsuarioModifico { get; set; }
         [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }
    }
}