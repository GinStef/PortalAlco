using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;  
using portal.bdpossuc;

namespace portal.Reportes.TotalVenta
{
    public static class Reporte
    {
        public static WebApplication RegistraReporte(this WebApplication app)
        {
            app.MapGet("/VentaTotal/PorTienda", async (
                [FromServices] IConfiguration config,
                DateTime fechaIni, DateTime fechaFin, int idUnidadOperativa = 0

            ) =>
            {

                var connectionString = config.GetConnectionString("bdpos");

                using var conn = new SqlConnection(connectionString);

                var result = await conn.QueryAsync(
                    "spGHs_Rep_Venta_x_suc",
                    new
                    {
                        as_fecha_ini = fechaIni.ToString("yyyyMMdd"),
                        as_fecha_fin = fechaFin.ToString("yyyyMMdd"),
                        al_id_uni_oper = idUnidadOperativa
                    },
                    commandType: System.Data.CommandType.StoredProcedure
                );

                return Results.Ok(result);
            });

            return app;
        }
    }
}
