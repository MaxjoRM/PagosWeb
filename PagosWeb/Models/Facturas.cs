namespace PagosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas()
        {
            DetalleFactura = new HashSet<DetalleFactura>();
            FacturaAbono = new HashSet<FacturaAbono>();
        }

        [Key]
        public int FacturaId { get; set; }

        public DateTime FechaFactura { get; set; }

        public decimal MontoFactura { get; set; }

        public decimal Saldo { get; set; }

        public int ClienteId { get; set; }

        public bool Cancelado { get; set; }
        [NotMapped]
        public string FacturaRef { get { return "ID:"+FacturaId+" F:" + FechaFactura; } }

        public virtual Clientes Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaAbono> FacturaAbono { get; set; }
    }
}
