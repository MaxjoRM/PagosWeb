namespace PagosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            Facturas = new HashSet<Facturas>();
        }

        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(16)]
        public string CedulaCliente { get; set; }

        [Required]
        [StringLength(50)]
        public string NombresCliente { get; set; }

        [StringLength(50)]
        public string ApellidosCliente { get; set; }

        [StringLength(100)]
        public string DireccionCliente { get; set; }

        [NotMapped]
        public string NombreCompleto { get { return ApellidosCliente.Trim() + " " + NombresCliente.Trim(); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
