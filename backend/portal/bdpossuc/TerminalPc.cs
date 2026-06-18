using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TerminalPc
{
    public int IdTerminal { get; set; }

    public int IdPc { get; set; }

    public short IdUniOper { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual MaqPc IdPcNavigation { get; set; } = null!;

    public virtual Terminal IdTerminalNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
