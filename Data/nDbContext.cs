using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAdmin.Models;

namespace WebAdmin.Data
{
    public class nDbContext : IdentityDbContext
    {
        public nDbContext(DbContextOptions<nDbContext> options)
            : base(options)
        {
        }

        public DbSet<CatCodigosPostal> CatCodigosPostales { get; set; }
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }

        public DbSet<CatEstatus> CatEstatus { get; set; }
        public DbSet<CatPerfil> CatPerfiles { get; set; }
        public DbSet<CatRole> CatRoles { get; set; }

        public DbSet<CatArea> CatAreas { get; set; }

        public DbSet<CatGenero> CatGeneros { get; set; }
        public DbSet<TblEmpresa> TblEmpresa { get; set; }
        public DbSet<TblCentro> TblCentros { get; set; }

        public DbSet<TblCorporativo> TblCorporativos { get; set; }
        public DbSet<TblUsuario> TblUsuarios { get; set; }

        public DbSet<CatTipoDireccion> CatTipoDirecciones { get; set; }

        public DbSet<TblCliente> TblClientes { get; set; }
        public DbSet<TblClienteContacto> TblClienteContactos { get; set; }
        public DbSet<TblClienteDireccion> TblClienteDirecciones { get; set; }

        public DbSet<TblEmpresa> TblEmpresas { get; set; }
        public DbSet<TblProveedor> TblProveedores { get; set; }
        public DbSet<TblProveedorContacto> TblProveedorContactos { get; set; }
        public DbSet<TblProveedorDireccion> TblProveedorDirecciones { get; set; }

        public DbSet<CatCategoria> CatCategorias { get; set; }
        public DbSet<CatProducto> CatProductos { get; set; }
        public DbSet<CatTipoCentro> CatTipoCentros { get; set; }
        public DbSet<WebAdmin.Models.CatEscolaridad> CatEscolaridad { get; set; }
        public DbSet<WebAdmin.Models.CatNivelEscolar> CatNivelEscolar { get; set; }
        public DbSet<WebAdmin.Models.CatTipoAlumno> CatTipoAlumno { get; set; }
        public DbSet<WebAdmin.Models.CatTipoContratacion> CatTipoContratacion { get; set; }
        public DbSet<WebAdmin.Models.CatTipoPago> CatTipoPago { get; set; }
        public DbSet<WebAdmin.Models.CatTipoPrestamo> CatTipoPrestamo { get; set; }
        public DbSet<WebAdmin.Models.CatTipoServicio> CatTipoServicio { get; set; }
        
    }
}