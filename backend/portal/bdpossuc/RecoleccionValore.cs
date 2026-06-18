using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class RecoleccionValore
{
    public int IdMovimiento { get; set; }

    public int IdUniOper { get; set; }

    public int IdCompaniaValores { get; set; }

    public DateTime FechaRecoleccion { get; set; }

    public string UsuarioMovimiento { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public short IndVigente { get; set; }
}
