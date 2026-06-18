using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatUnidadMedidum
{
    public int IdUnidadMedidaSat { get; set; }

    public string CveUnidadMedida { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Nota { get; set; }

    public DateTime? FechaIniVig { get; set; }

    public DateTime? FechaFinVig { get; set; }

    public string? Simbolo { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
