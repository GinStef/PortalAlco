// Campos fijos de totales
export interface TotalesSucursal {
    "Total general"?: number;
}

// Reporte por sucursal
export interface ReporteSucursal extends TotalesSucursal {
    Sucursal: string;

    // Fechas dinámicas YYYYMMDD
    fechas: Record<string, number>;
}
