using Ej7MantMvcDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ej7MantMvcDoctores.Controllers
{
    public class DoctoresController : Controller
    {
        
        public ActionResult Index()
        {
            ModeloDoctor modelo = new ModeloDoctor();
            List<DOCTOR> lista = modelo.MostrarDoctores();             
            return View(lista);
        }

        public ActionResult Edit(int id)
        {
            ModeloDoctor modelo = new ModeloDoctor();
            DOCTOR doc = modelo.EditarDoctor(id);
            return View(doc);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Create(String hosCod, String docNum, String ape, String esp, int sal)
        {
            ModeloDoctor modelo = new ModeloDoctor();
            modelo.InsertarDoctor(hosCod, docNum, ape, esp, sal);
            return RedirectToAction("Index");
        }

        public ActionResult Update(String hosCod, String docNum, String ape, String esp, int sal)
        {
            ModeloDoctor modelo = new ModeloDoctor();
            modelo.ModificarDoctor(hosCod, docNum, ape, esp, sal);
            return RedirectToAction("Index");
        }

       
        public ActionResult Destroy(int id)
        {
            ModeloDoctor modelo = new ModeloDoctor();
            modelo.EliminarDoctor(id);
            return RedirectToAction("Index");
        }
    }
}