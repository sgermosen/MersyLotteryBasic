using System;

namespace Mersy.Web.Models
{
    public class VistaVenta
    {
        public string No_Factura { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? Fecha_Saldado { get; set; }

        public string Cliente { get; set; }

        public string Estado_Factura { get; set; }

        public string Comentarios { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Total_Descuento { get; set; }

        public decimal Total_Cargos { get; set; }

        public decimal Total { get; set; }

        public decimal Monto_Pagado { get; set; }

        public decimal Monto_Adeudado { get; set; }

        public string Caja { get; set; }

        public string Usuario { get; set; }

        public string No_Autorizacion { get; set; }

        public string Seguro { get; set; }
    }
}
