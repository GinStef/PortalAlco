using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdCliente
{
    public int Idproceso { get; set; }

    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string NumeroExterior { get; set; } = null!;

    public string? NumeroInterior { get; set; }

    public string? Colonia { get; set; }

    public int CodigoPostal { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string? CvePais { get; set; }
}
