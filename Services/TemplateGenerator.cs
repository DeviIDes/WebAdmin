using System.Collections.Generic;
using System.Text;
using WebAdmin.ViewModels;

namespace WebAdmin.Services
{
    public class TemplateGenerator
    {
        public static string GetHTMLString()
        {


            List<VentasViewModel> GetAllVentas = new List<VentasViewModel>();



            var ventas = GetAllVentas;
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>Contruccion de Reporte</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Uno</th>
                                        <th>Dos</th>
                                        <th>Tres</th>
                                        <th>Cuatro</th>
                                    </tr>");
            foreach (var item in ventas)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", item.TblVentas.IdVenta, item.TblVentas.NumeroVenta, item.TblVentas.IdUsuarioVenta, item.TblVentas.IdCentro);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();

        }
    }
}
