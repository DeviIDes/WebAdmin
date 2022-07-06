using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAdmin.Models
{
    public class RelVentasPagos
    {
        [Display(Name = "ID Ventas Pagos")]
        [Key]
        public Guid IdRelVentasPago { get; set; }

        [Display(Name = "Codigo Referencia")]
        public string CodigoReferencia { get; set; } 

        [Display(Name = "Descuento")]
        public int CantidadPago { get; set; } 

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