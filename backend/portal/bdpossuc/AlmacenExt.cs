using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class AlmacenExt
{
    public short IdAlmacen { get; set; }

    public string NomAlmacen { get; set; } = null!;

    public string AbrevAlmacen { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }
}
