using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SesionUnidadOperativa
{
    public int Spid { get; set; }

    public int IdUniOper { get; set; }

    public string NomUnioper { get; set; } = null!;

    public string AbrevUnioper { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public byte IndLocal { get; set; }
}
