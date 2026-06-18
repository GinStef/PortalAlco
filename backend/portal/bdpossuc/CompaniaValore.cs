using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CompaniaValore
{
    public int Id { get; set; }

    public int IdUniOper { get; set; }

    public string Nombre { get; set; } = null!;

    public string Abrev { get; set; } = null!;

    public string UsuarioMovimiento { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public short IndVigente { get; set; }
}
