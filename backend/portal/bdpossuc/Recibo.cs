using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Recibo
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public int? IdCompra { get; set; }

    public int IdProveedor { get; set; }

    public string? Comentario { get; set; }

    public string UsuarioRecepcion { get; set; } = null!;

    public DateTime FechaRecibo { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public byte IdEstatus { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? Factura { get; set; }

    public byte IndInterfase { get; set; }

    public DateTime? FechaInterfase { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual TipoMovimiento IdTipomovNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
