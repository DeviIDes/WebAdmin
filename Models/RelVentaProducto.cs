using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAdmin.Models
{
    public class RelVentaProducto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        [Display(Name = "Total")]

        public double TotalCostoProducto { get; set; }
        [Display(Name = "Usuario")]
        public Guid IdUsuarioModifico { get; set; }
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }

        public Guid IdVenta { get; set; }
    }
}
