using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoTicket
{
    public short IdTipoTicket { get; set; }

    public string DescripcionTipo { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<TipoTicketDetalle> TipoTicketDetalles { get; set; } = new List<TipoTicketDetalle>();

    public virtual ICollection<TipoTicketUnidad> TipoTicketUnidads { get; set; } = new List<TipoTicketUnidad>();
}
