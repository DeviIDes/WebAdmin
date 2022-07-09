using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAdmin.Models;

namespace WebAdmin.ViewModels 
{
    public class VentasViewModel
    {
          public TblVenta TblVentas { get; set; }
        public List<RelVentaProducto> RelVentaProductos { get; set; }
    }
}