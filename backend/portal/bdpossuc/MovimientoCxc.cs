using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoCxc
{
    public short IdUniOper { get; set; }

    public int FolioMov { get; set; }

    public short IdTipomov { get; set; }

    public int IdCliente { get; set; }

    public decimal MontoMn { get; set; }

    public decimal SaldoAnterior { get; set; }

    public byte IdTipoDoc { get; set; }

    public int IdUniOperDoc { get; set; }

    public int IdMovimientoDoc { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<MovimientoCxcDet> MovimientoCxcDets { get; set; } = new List<MovimientoCxcDet>();
}
