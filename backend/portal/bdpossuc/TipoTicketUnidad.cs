using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoTicketUnidad
{
    public short IdTipoTicket { get; set; }

    public short IdUniOper { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual TipoTicket IdTipoTicketNavigation { get; set; } = null!;
}
