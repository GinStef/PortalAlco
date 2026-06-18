using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UnidadOperativaClienteExt
{
    public short IdUniOper { get; set; }

    public int IdCliente { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }
}
