using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CambioPrecioDet
{
    public int IdFolioDet { get; set; }

    public int IdFolio { get; set; }

    public short IdUniOper { get; set; }

    public int Sku { get; set; }

    public short IdLista { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? FechaFin { get; set; }

    public DateTime? FechaApl { get; set; }

    public string Estatus { get; set; } = null!;

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public virtual ICollection<CambioPrecioDetPl> CambioPrecioDetPls { get; set; } = new List<CambioPrecioDetPl>();
}
