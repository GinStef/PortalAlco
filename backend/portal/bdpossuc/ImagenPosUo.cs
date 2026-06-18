using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ImagenPosUo
{
    public short IdImagenPos { get; set; }

    public short IdUniOper { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual ImagenPo IdImagenPosNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
