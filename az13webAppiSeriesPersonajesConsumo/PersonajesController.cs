using Az13ApiSeriesPersonajesConsumo.Models;
using Az13ApiSeriesPersonajesConsumo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Az13ApiSeriesPersonajesConsumo.Controllers
{
    public class PersonajesController : Controller
    {
        RepositoryApiPersonajes repo;
        public PersonajesController(RepositoryApiPersonajes repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> PersonajesServidor()
        {
            List<Personaje> personajes = await
                this.repo.GetPersonajesAsync();
            return View(personajes);
        }

        public async Task<IActionResult> DetallesPersonaje(int numPer)
        {
            Personaje personaje =
                await this.repo.BuscarPersonajeAsync(numPer);
            return View(personaje);
        }

        public IActionResult InsertarPersonaje()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>InsertarPersonaje(Personaje personaje)
        {
            await this.repo.InsertarPersonajeAsync(personaje.IdPersonaje, personaje.Nombre,
                personaje.Imagen, personaje.IdSerie);
                
            return RedirectToAction("PersonajesServidor");
        }

        public async Task<IActionResult> ModificarPersonaje(int numPer)
        {
            Personaje personaje =
                await this.repo.BuscarPersonajeAsync(numPer);
            return View(personaje);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarPersonaje
            (Personaje personaje)
        {
            await this.repo.ModificarPersonajeAsync(personaje.IdPersonaje, personaje.Nombre
                , personaje.Imagen, personaje.IdSerie);
            return RedirectToAction("PersonajesServidor");
        }

        public async Task<IActionResult> EliminarPersonaje(int numPer)
        {
            await this.repo.EliminarPersonajeAsync(numPer);
            return RedirectToAction("PersonajesServidor");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartamentosCliente()
        {
            return View();
        }
    }
}

