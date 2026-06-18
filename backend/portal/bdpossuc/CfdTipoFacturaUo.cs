using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CfdTipoFacturaUo
{
    public short IdUniOper { get; set; }

    public byte IdTipofactura { get; set; }

    public string Sserie { get; set; } = null!;

    public int IfolioActual { get; set; }

    public byte BIndDefault { get; set; }

    public byte IndOrigen { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public byte BIndVigente { get; set; }

    public virtual ICollection<CfdTipoFacturaUoFolio> CfdTipoFacturaUoFolios { get; set; } = new List<CfdTipoFacturaUoFolio>();

    public virtual CfdTipoFactura IdTipofacturaNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
