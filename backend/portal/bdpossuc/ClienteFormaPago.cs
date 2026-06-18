using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ClienteFormaPago
{
    public int IdCliente { get; set; }

    public byte IdFormaPago { get; set; }

    public byte IdOrden { get; set; }

    public string? NumeroCuenta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
