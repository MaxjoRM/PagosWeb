namespace PagosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sucursales
    {
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        [StringLength(3)]
        public string CodigoSucursal { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreSucursal { get; set; }

        [Required]
        [StringLength(150)]
        public string DireccionSucursal { get; set; }
    }
}
