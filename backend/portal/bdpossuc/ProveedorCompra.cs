using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ProveedorCompra
{
    public int IdProveedor { get; set; }

    public short IdUniOperEntrega { get; set; }

    public short IdUniOperFactura { get; set; }

    public short FrecuenciaCompra { get; set; }

    public short DiasEntrega { get; set; }

    public bool IndAceptarParcial { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperEntregaNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperFacturaNavigation { get; set; } = null!;
}
