using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ImagenPosDet
{
    public short IdImagen { get; set; }

    public short IdImagenPos { get; set; }

    public bool TipoImagen { get; set; }

    public short Orden { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual ImagenPo IdImagenPosNavigation { get; set; } = null!;
}
