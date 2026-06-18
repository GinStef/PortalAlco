using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CambioPrecioDetPl
{
    public int IdFolioDet { get; set; }

    public int IdFolio { get; set; }

    public short IdUniOper { get; set; }

    public short IdTipoprecio { get; set; }

    public short IdImpuesto { get; set; }

    public decimal Precio { get; set; }

    public decimal PrecioSinIva { get; set; }

    public virtual CambioPrecioDet CambioPrecioDet { get; set; } = null!;
}
