using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CfdTipoFactura
{
    public byte IdTipofactura { get; set; }

    public string NomTipofactura { get; set; } = null!;

    public string AbrevTipofactura { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public string? NoVersion { get; set; }

    public byte IndCfdi { get; set; }

    public virtual ICollection<CfdTipoFacturaUo> CfdTipoFacturaUos { get; set; } = new List<CfdTipoFacturaUo>();
}
