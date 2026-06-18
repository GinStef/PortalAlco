using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MaqPcDet
{
    public int IdPcDet { get; set; }

    public short IdUniOper { get; set; }

    public int IdPc { get; set; }

    public string Mac { get; set; } = null!;

    public string Adaptador { get; set; } = null!;

    public string NombreAdaptador { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public int Indice { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual MaqPc IdPcNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
