using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Web.Models
{
    public class VistaVentaDetalle
    {

        public string No_Factura { get; set; }

        public DateTime? Fecha { get; set; }

        public string Cliente { get; set; }

        public string Caja { get; set; }

        public string Usuario { get; set; }

        public string No_Autorizacion { get; set; }

        public string Seguro { get; set; }

        public string Categoria { get; set; }

        public string Servicio { get; set; }

        public decimal Cantidad { get; set; }

        public string Unidad_Medida { get; set; }

        public decimal Sub_Total { get; set; }

        public decimal Descuento { get; set; }

        public decimal Cargos { get; set; }

        public decimal Valor { get; set; }
    }
}
