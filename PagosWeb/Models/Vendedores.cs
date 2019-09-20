namespace PagosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendedores
    {
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        [StringLength(3)]
        public string CodigoVendedor { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreVendedor { get; set; }

        [StringLength(50)]
        public string ApellidosVendedor { get; set; }

        [StringLength(8)]
        public string TelefonoVendedor { get; set; }

        [Required]
        [StringLength(25)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(25)]
        public string Contrasenia { get; set; }
    }
}
