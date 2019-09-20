namespace PagosWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PagosDb : DbContext
    {
        public PagosDb()
            : base("name=PagosDb")
        {
        }

        public virtual DbSet<Articulo> Articulos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetallesFactura { get; set; }
        public virtual DbSet<FacturaAbono> FacturaAbono { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }

    }
}
