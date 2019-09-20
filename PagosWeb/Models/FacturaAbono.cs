namespace PagosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaAbono")]
    public partial class FacturaAbono
    {
        public int FacturaAbonoId { get; set; }

        public DateTime FechaAbono { get; set; }

        public decimal MontoAbono { get; set; }

        public decimal SaldoAnterior { get; set; }

        [StringLength(100)]
        public string Notas { get; set; }

        public int FacturaId { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
