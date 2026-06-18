using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoTarjetaCf
{
    public byte IdTipoTarjeta { get; set; }

    public string NomTipotarjeta { get; set; } = null!;

    public string AbrevTipotarjeta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime? FechaMovimiento { get; set; }

    public string? UsuarioModifica { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<TarjetaCf> TarjetaCfs { get; set; } = new List<TarjetaCf>();
}
