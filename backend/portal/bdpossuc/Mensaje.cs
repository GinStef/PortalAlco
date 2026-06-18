using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Mensaje
{
    public int IdMensaje { get; set; }

    public string DescripMensaje { get; set; } = null!;

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }
}
