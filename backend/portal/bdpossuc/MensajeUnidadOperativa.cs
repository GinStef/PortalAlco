using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MensajeUnidadOperativa
{
    public int IdMensaje { get; set; }

    public short IdUnidadOperativa { get; set; }

    public bool IndVigente { get; set; }

    public virtual UnidadOperativa IdUnidadOperativaNavigation { get; set; } = null!;
}
