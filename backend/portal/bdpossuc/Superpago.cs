using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Superpago
{
    public int IdUniOper { get; set; }

    public int IdSuperpago { get; set; }

    public int? IdCliente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? CveEstatus { get; set; }

    public decimal? Monto { get; set; }

    public decimal? MontoMn { get; set; }

    public short? IdTipomovCxc { get; set; }

    public int? FolioMovCxc { get; set; }

    public short? IdTipomovAnulaCxc { get; set; }

    public int? FolioMovAnulaCxc { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? IdCorte { get; set; }

    public int? IdCaja { get; set; }

    public virtual ICollection<SuperpagoDet> SuperpagoDets { get; set; } = new List<SuperpagoDet>();
}
