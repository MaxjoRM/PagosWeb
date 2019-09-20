namespace PagosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleFactura")]
    public partial class DetalleFactura
    {
        public int DetalleFacturaId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public int FacturaId { get; set; }

        public int ArticuloId { get; set; }

        public virtual Articulo Articulo { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
