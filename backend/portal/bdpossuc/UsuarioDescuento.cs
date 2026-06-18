using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UsuarioDescuento
{
    public int IdUsuario { get; set; }

    public short IdDescuento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual DescuentoSupervisor IdDescuentoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
