using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ClienteTarjetaCf
{
    public int IdCliente { get; set; }

    public int IdTarjeta { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual TarjetaCfDet IdTarjetaNavigation { get; set; } = null!;
}
