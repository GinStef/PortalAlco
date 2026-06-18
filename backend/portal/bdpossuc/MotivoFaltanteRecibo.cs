using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MotivoFaltanteRecibo
{
    public short IdMotivo { get; set; }

    public string NomMotivo { get; set; } = null!;

    public string AbrevMotivo { get; set; } = null!;

    public bool IndAfectaInv { get; set; }

    public short? IdTipomov { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }
}
