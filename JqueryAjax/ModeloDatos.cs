using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryAjax.Models
{
    public class ModeloDatos
    {
        DatosDataContext contexto = new DatosDataContext();

        public List<HOSPITAL> devolverDatosHospital() {

            var datos = from hos in contexto.HOSPITAL
                        select hos;
            return datos.ToList();
        }

        public List<DOCTOR> devolverDatosDoctores()
        {
            var datos = from doc in contexto.DOCTOR
                        select doc;
            return datos.ToList();
        }

        public List<PLANTILLA> devolverDatosPlantilla()
        {
            var datos = from pla in contexto.PLANTILLA
                        select pla;
            return datos.ToList();
        }
    }
}