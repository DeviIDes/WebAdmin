using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdmin.Models
{
    public class TblVenta
    {
        [Display(Name = "ID Cotización")]
        [Key]
        public Guid IdVenta { get; set; }
        [Display(Name = "Numero Cotización")]

        public int NumeroVenta { get; set; }
[Display(Name = "Usuario")]
[Required(ErrorMessage = "Campo Requerido")]
         public Guid IdUsuarioVenta { get; set; }
  [Display(Name = "Centro")]
  [Required(ErrorMessage = "Campo Requerido")]
            public Guid IdCentro { get; set; }
        [Display(Name = "Alumno")]
        [Required(ErrorMessage = "Campo Requerido")]
            public Guid IdCliente { get; set; }

[Display(Name = "Descuento %")]
        public int Descuento { get; set; }
[Display(Name = "Tipo de Pago")]
[Required(ErrorMessage = "Campo Requerido")]
        public int IdTipoPago { get; set; }
                 [Display(Name = "Codigo / Referencia")]
           [NotMapped]
        public string CodigoPago { get; set; }

 [Display(Name = "Fecha Altera")]
        [DataType(DataType.Date)]
        public DateTime FechaAlterna { get; set; }
                    [Display(Name = "Usuario")]
        public Guid IdUsuarioModifico { get; set; }
         [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }

         [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Campo Requerido")]
         [NotMapped]
        public int IdCategoria { get; set; }
[Display(Name = "Producto")]
        
         [NotMapped]
          public int IdProducto { get; set; }

          [Display(Name = "Categoria")]
           [NotMapped]
        public string DescCategoria { get; set; }

          [Display(Name = "Producto")]
           [NotMapped]
        public string DescProducto { get; set; }

          [Display(Name = "Costo")]
           [NotMapped]
        public double Costo { get; set; }

          [Display(Name = "Total")]
           [NotMapped]
        public double Total { get; set; }

  
        
        


    }
}