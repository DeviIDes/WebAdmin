using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblCorporativo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCorporativo { get; set; }

        [Display(Name = "Tipo de Licencia")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string IdTipoLicencia { get; set; }

        [Display(Name = "Tipo de Corporativo")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string IdTipoCorporativo { get; set; }

        [Display(Name = "Nombre de Corporativo")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string NombreCorporativo { get; set; }

        [Display(Name = "Calle")]
        public string Calle { get; set; }

        [Display(Name = "Codigo Postal")]
        public string CodigoPostal { get; set; }

        public string IdColonia { get; set; }

        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Display(Name = "Localidad / Municipio")]
        public string LocalidadMunicipio { get; set; }

        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string CorreoElectronico { get; set; }

        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [ForeignKey("TblEmpresa")]
        public Guid IdEmpresa { get; set; }

        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        public int IdEstatusRegistro { get; set; }

        public TblCorporativo()
        {
            CatAreas = new HashSet<CatArea>();
            CatCategorias = new HashSet<CatCategoria>();
            CatEscolaridads = new HashSet<CatEscolaridad>();
            CatEstatus = new HashSet<CatEstatus>();
            CatGeneros = new HashSet<CatGenero>();
            CatNivelEscolars = new HashSet<CatNivelEscolar>();
            CatPerfiles = new HashSet<CatPerfil>();
            CatRoles = new HashSet<CatRole>();
            CatTipoAlumnos = new HashSet<CatTipoAlumno>();
            CatTipoCentros = new HashSet<CatTipoCentro>();
            CatTipoContratacions = new HashSet<CatTipoContratacion>();
            CatTipoDireccions = new HashSet<CatTipoDireccion>();
            CatTipoPagos = new HashSet<CatTipoPago>();
            CatTipoPrestamos = new HashSet<CatTipoPrestamo>();
            CatTipoServicios = new HashSet<CatTipoServicio>();
            TblCentros = new HashSet<TblCentro>();
            TblClientes = new HashSet<TblCliente>();
            TblProveedores = new HashSet<TblProveedor>();
        }

        public virtual ICollection<CatArea> CatAreas { get; set; }
        public virtual ICollection<CatCategoria> CatCategorias { get; set; }
        public virtual ICollection<CatEscolaridad> CatEscolaridads { get; set; }
        public virtual ICollection<CatEstatus> CatEstatus { get; set; }
        public virtual ICollection<CatGenero> CatGeneros { get; set; }
       
        public virtual ICollection<CatNivelEscolar> CatNivelEscolars { get; set; }
        public virtual ICollection<CatPerfil> CatPerfiles { get; set; }
       
        public virtual ICollection<CatRole> CatRoles { get; set; }
        public virtual ICollection<CatTipoAlumno> CatTipoAlumnos { get; set; }
        public virtual ICollection<CatTipoCentro> CatTipoCentros { get; set; }
        public virtual ICollection<CatTipoContratacion> CatTipoContratacions { get; set; }
        public virtual ICollection<CatTipoDireccion> CatTipoDireccions { get; set; }
        public virtual ICollection<CatTipoPago> CatTipoPagos { get; set; }
        public virtual ICollection<CatTipoPrestamo> CatTipoPrestamos { get; set; }
        public virtual ICollection<CatTipoServicio> CatTipoServicios { get; set; }
        public virtual ICollection<TblCentro> TblCentros { get; set; }
        public virtual ICollection<TblCliente> TblClientes { get; set; }
        public virtual ICollection<TblProveedor> TblProveedores { get; set; }


    }
}