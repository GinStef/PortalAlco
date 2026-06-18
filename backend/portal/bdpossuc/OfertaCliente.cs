using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class OfertaCliente
{
    public int IdFolio { get; set; }

    public short IdUniOper { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdFolioDet { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public virtual ICollection<OfertaClienteDet> OfertaClienteDets { get; set; } = new List<OfertaClienteDet>();
}
