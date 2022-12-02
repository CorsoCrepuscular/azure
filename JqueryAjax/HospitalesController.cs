using JqueryAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAjax.Controllers
{
    public class HospitalesController : Controller
    {
        DatosDataContext contexto = new DatosDataContext();

        List<HOSPITAL> listahospitales;
        List<DOCTOR> listadoctores;    
        List<PLANTILLA> listaplantilla; 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RecuperarHospitales()
        {
            ModeloDatos m=new ModeloDatos();
            listahospitales = m.devolverDatosHospital();
            return View("_ListaHospitales", this.listahospitales);
        }
        public ActionResult RecuperarDoctores()
        {
            ModeloDatos m= new ModeloDatos();
            listadoctores = m.devolverDatosDoctores();
            return View("_ListaDoctores", this.listadoctores);
            
        }
        public ActionResult RecuperarPlantilla()
        {
            ModeloDatos m = new ModeloDatos();
            listaplantilla = m.devolverDatosPlantilla();
            return View("_ListaPlantilla", this.listaplantilla);
        }
    }
}