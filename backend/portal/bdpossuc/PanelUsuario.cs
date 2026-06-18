using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class PanelUsuario
{
    public short IdPanel { get; set; }

    public int IdUsuario { get; set; }

    public bool IndImprimir { get; set; }

    public bool IndAgregar { get; set; }

    public bool IndBorrar { get; set; }

    public bool IndActualizar { get; set; }

    public virtual Panel IdPanelNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
