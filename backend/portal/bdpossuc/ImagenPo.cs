using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ImagenPo
{
    public short IdImagenPos { get; set; }

    public string NomImagen { get; set; } = null!;

    public short Intervalo { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual ICollection<ImagenPosDet> ImagenPosDets { get; set; } = new List<ImagenPosDet>();

    public virtual ICollection<ImagenPosUo> ImagenPosUos { get; set; } = new List<ImagenPosUo>();
}
