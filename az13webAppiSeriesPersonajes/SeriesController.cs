using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using az13ApiSeriesPersonajes.Repositories;
using az13ApiSeriesPersonajes.Models;

namespace az13ApiSeriesPersonajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        RepositorySeries repo;
        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Serie>> GetSeries()
        {
            return this.repo.GetSeries();
        }

        [HttpGet("{id}")]
        public ActionResult<Serie> BuscarSerie(int id)
        {
            return this.repo.BuscarSerie(id);
        }

        //api/Series --> POST
        [HttpPost]
        public void InsertarSerie(Serie serie) 
        {
            this.repo.InsertarSerie(serie.IdSerie, serie.Nombre,
                serie.Imagen, serie.Puntuacion, serie.Año);
        }

        //api/Series --> PUT
        [HttpPut]
        public void ModificarSerie(Serie serie)
        {
            this.repo.ModificarSerie(serie.IdSerie, serie.Nombre,
                serie.Imagen, serie.Puntuacion, serie.Año);
        }

        //api/Series --> DELETE
        [HttpDelete("{id}")]
        public void BorrarSerie(int id)
        {
            this.repo.BorrarSerie(id);
        }

    }
}
