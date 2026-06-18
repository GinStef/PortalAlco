using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class DescuentoSupervisor
{
    public short IdDescuento { get; set; }

    public string DescripcionDescuento { get; set; } = null!;

    public decimal ValorPorcDescuento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<UsuarioDescuento> UsuarioDescuentos { get; set; } = new List<UsuarioDescuento>();
}
