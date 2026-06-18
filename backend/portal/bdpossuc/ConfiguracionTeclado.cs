using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ConfiguracionTeclado
{
    public short IdTecla { get; set; }

    public short? IdFuncion { get; set; }

    public string AbrevTecla { get; set; } = null!;

    public bool IndRequiereAutorizacion { get; set; }

    public bool? IndManauto { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public byte Numsesionventa { get; set; }

    public byte Numsesionpago { get; set; }

    public byte IndImagen { get; set; }

    public string? Imagen { get; set; }
}
