using Microsoft.AspNetCore.Mvc;
using MvcDockersMySqlV6.Repositories;

namespace MvcDockersMySqlV6.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetDepartamentos());
        }

        public IActionResult Details(int id)
        {
            return View(this.repo.FindDepartamento(id));
        }

        [HttpPost]
        public IActionResult Insertar(int id, string nom, string loc)
        {
            this.repo.InsertarDepartamento(id, nom, loc);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            this.repo.EliminarDepartamento(id);  
            return RedirectToAction ("Index");
            
        }

        [HttpPost]
        public IActionResult Modificar(int id, string nom, string loc)
        {
            this.repo.EditDepartamento(id, nom, loc);
            return RedirectToAction("Index");

        }
    }
}
