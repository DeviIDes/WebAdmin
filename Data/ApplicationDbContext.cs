using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAdmin.Models;

namespace WebAdmin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CatCodigosPostale> CatCodigosPostales { get; set; }
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }

        public DbSet<CatEstatus> CatEstatus { get; set; }
        public DbSet<CatPerfil> CatPerfiles { get; set; }
        public DbSet<CatRole> CatRoles { get; set; }

        public DbSet<CatArea> CatAreas { get; set; }

        public DbSet<CatGenero> CatGeneros { get; set; }
        public DbSet<TblEmpresa> TblEmpresa { get; set; }
        public DbSet<TblCentros> TblCentros { get; set; }
        public DbSet<TblUsuario> TblUsuarios { get; set; }
    }
}