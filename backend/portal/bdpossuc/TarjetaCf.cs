using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TarjetaCf
{
    public int IdTarjetaCf { get; set; }

    public byte IdTipoTarjeta { get; set; }

    public int IdLote { get; set; }

    public int Cantidad { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime? FechaMovimiento { get; set; }

    public string? UsuarioModifica { get; set; }

    public bool IndVigente { get; set; }

    public virtual TipoTarjetaCf IdTipoTarjetaNavigation { get; set; } = null!;
}
