using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MaqPc
{
    public int IdPc { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<MaqPcDet> MaqPcDets { get; set; } = new List<MaqPcDet>();

    public virtual ICollection<TerminalPc> TerminalPcs { get; set; } = new List<TerminalPc>();
}
