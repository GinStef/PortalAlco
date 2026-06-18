using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class VentaDevolucion
{
    public short IdUniOper { get; set; }

    public int IdDevolucion { get; set; }

    public int IdVenta { get; set; }

    public byte IdEstatus { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Total { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public int IdUsuario { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? IdUsuarioAnula { get; set; }

    public string? Comentario { get; set; }

    public int? IdCaja { get; set; }

    public int? IdCorte { get; set; }

    public virtual TipoMovimiento IdTipomovNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<VentaDevolucionDetalle> VentaDevolucionDetalles { get; set; } = new List<VentaDevolucionDetalle>();

    public virtual Ventum Ventum { get; set; } = null!;
}
