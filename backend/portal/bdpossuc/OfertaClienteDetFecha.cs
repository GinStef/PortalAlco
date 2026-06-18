using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class OfertaClienteDetFecha
{
    public int IdFolioDet { get; set; }

    public int IdFolio { get; set; }

    public short IdUniOperFolio { get; set; }

    public int Sku { get; set; }

    public short IdUniOper { get; set; }

    public byte IdTipoOferta { get; set; }

    public string Estatus { get; set; } = null!;

    public decimal PrecioOferta { get; set; }

    public decimal PrecioOfertaSinIva { get; set; }

    public decimal Descuento { get; set; }

    public short IdImpuesto { get; set; }

    public byte? IdTipoFecha { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }
}
