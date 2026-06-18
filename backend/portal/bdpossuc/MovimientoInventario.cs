using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoInventario
{
    public short IdUniOper { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public short? IdUniOperTras { get; set; }

    public int FolioDoc { get; set; }

    public DateTime FechaAplica { get; set; }

    public virtual TipoMovimiento IdTipomovNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<MovimientoInventarioDet> MovimientoInventarioDets { get; set; } = new List<MovimientoInventarioDet>();
}
