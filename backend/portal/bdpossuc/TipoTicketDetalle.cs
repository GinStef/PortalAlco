using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoTicketDetalle
{
    public short IdTipoTicket { get; set; }

    public short IdTicket { get; set; }

    public bool TipoDescripcion { get; set; }

    public byte Orden { get; set; }

    public string? Descripcion { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual TipoTicket IdTipoTicketNavigation { get; set; } = null!;
}
