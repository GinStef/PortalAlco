using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UsuarioUnidadOperativa
{
    public int IdUsuario { get; set; }

    public short IdUniOper { get; set; }

    public bool IndOpera { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
