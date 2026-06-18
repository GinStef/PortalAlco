using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Merma
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public string? Comentario { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public byte IdEstatus { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public byte IndInterfase { get; set; }

    public DateTime? FechaInterfase { get; set; }

    public virtual TipoMovimiento IdTipomovNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<MermaDet> MermaDets { get; set; } = new List<MermaDet>();
}
