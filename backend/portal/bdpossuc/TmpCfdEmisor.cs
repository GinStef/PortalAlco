using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdEmisor
{
    public int IdProceso { get; set; }

    public int IdUniOper { get; set; }

    public string EmiNombre { get; set; } = null!;

    public string EmiRfc { get; set; } = null!;

    public string EmiDireccion { get; set; } = null!;

    public string EmiNumeroExterior { get; set; } = null!;

    public string EmiNumeroInterior { get; set; } = null!;

    public string? EmiColonia { get; set; }

    public int EmiCodigoPostal { get; set; }

    public string EmiCiudad { get; set; } = null!;

    public string EmiEstado { get; set; } = null!;

    public string EmiPais { get; set; } = null!;

    public string ExpNombre { get; set; } = null!;

    public string ExpDireccion { get; set; } = null!;

    public string ExpNumeroExterior { get; set; } = null!;

    public string ExpNumeroInterior { get; set; } = null!;

    public string? ExpColonia { get; set; }

    public int ExpCodigoPostal { get; set; }

    public string ExpCiudad { get; set; } = null!;

    public string ExpEstado { get; set; } = null!;

    public string ExpPais { get; set; } = null!;

    public string? ExpTelefono { get; set; }

    public string? EmiTelefono { get; set; }

    public string? RegimenFiscal { get; set; }

    public string? ExpLocalidad { get; set; }

    public string? PacUser { get; set; }

    public string? PacPassword { get; set; }

    public string? CvePais { get; set; }

    public string? CveRegimenFiscal { get; set; }

    public string? PacIdentificador { get; set; }
}
