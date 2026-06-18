using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portal.bdpossuc;
using portal.Dto.UnidadOperativa;

namespace portal.Reportes.UnidadOperativa
{
    public static class UnidadOperativaEndpoints
    {
        public static WebApplication RegistrarUnidadOperativa(this WebApplication app)
        {
            app.MapGet("/UnidadesOperativas", async ([FromServices] BdpossucContext context) =>
            {
                var unidades = await context.UnidadOperativas
                    .AsNoTracking()
                    .Where(x => x.IndVigente)
                    .Select(x => new UnidadOperativaDto
                    {
                        Id = x.IdUniOper,
                        Nombre = x.NomUnioper
                    })
                    .ToListAsync();

              // Agregar opción "Todos"
                unidades.Insert(0, new UnidadOperativaDto { Id = 0, Nombre = "Todos" });

                return Results.Ok(unidades);
            });

            return app;
        }
    }
}
