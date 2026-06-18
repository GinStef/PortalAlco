using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Requisicion
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short IdUniOperSurte { get; set; }

    public string CveEstatus { get; set; } = null!;

    public string? Comentario { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string? UsuarioTermina { get; set; }

    public DateTime? FechaTermina { get; set; }

    public byte IndInterfase { get; set; }

    public DateTime? FechaInterfase { get; set; }

    public DateTime? FechaUtilizacion { get; set; }

    public short? IdUniOperSolicita { get; set; }

    public byte? IdTipo { get; set; }

    public virtual ICollection<RequisicionDet> RequisicionDets { get; set; } = new List<RequisicionDet>();
}
