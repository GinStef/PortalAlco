using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Empresa
{
    public short IdEmpresa { get; set; }

    public string NomComercial { get; set; } = null!;

    public string NomEmpresa { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string CalleYNumero { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public int IdCiudad { get; set; }

    public string Telefono { get; set; } = null!;

    public string? ImagenEmpresa { get; set; }

    public string? ImagenEmpresaReportes { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public string? NumeroInterior { get; set; }

    public string? NumeroExterior { get; set; }

    public string CodigoPostal { get; set; } = null!;

    public string? Paginaweb { get; set; }

    public string? RegimenFiscal { get; set; }

    public string? AbrevEmpresa { get; set; }

    public string? PacUser { get; set; }

    public string? PacPassword { get; set; }

    public virtual Ciudad IdCiudadNavigation { get; set; } = null!;

    public virtual ICollection<UnidadOperativa> UnidadOperativas { get; set; } = new List<UnidadOperativa>();
}
