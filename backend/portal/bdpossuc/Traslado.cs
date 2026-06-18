using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Traslado
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public byte IdTipo { get; set; }

    public short IdUniOperDestino { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public string? Comentario { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public byte IdEstatus { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? IdMovimientoReq { get; set; }

    public byte IndInterfase { get; set; }

    public DateTime? FechaInterfase { get; set; }

    public string? FolioInterfase { get; set; }

    public short? IdUniOperReq { get; set; }

    public virtual UnidadOperativa IdUniOperDestinoNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<TrasladoDet> TrasladoDets { get; set; } = new List<TrasladoDet>();

    public virtual ICollection<TrasladoRecibo> TrasladoRecibos { get; set; } = new List<TrasladoRecibo>();
}
