using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MonitorTerminal
{
    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public int IdUsuario { get; set; }

    public byte IndTipo { get; set; }

    public string Operacion { get; set; } = null!;
}
