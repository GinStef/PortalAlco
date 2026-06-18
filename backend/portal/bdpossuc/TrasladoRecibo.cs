using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TrasladoRecibo
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short IdUniOperOrigen { get; set; }

    public int IdTraslado { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public string UsuarioMovimiento { get; set; } = null!;

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public byte IdEstatus { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual Traslado Traslado { get; set; } = null!;

    public virtual ICollection<TrasladoReciboDet> TrasladoReciboDets { get; set; } = new List<TrasladoReciboDet>();
}
