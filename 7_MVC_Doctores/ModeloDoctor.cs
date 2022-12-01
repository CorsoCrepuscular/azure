using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ej7MantMvcDoctores.Models
{
    public class ModeloDoctor
    {
        DoctorDataContext contexto = new DoctorDataContext();

        public List<DOCTOR> MostrarDoctores()
        {
            var datos = from doc in contexto.DOCTOR
                        select doc;
            return datos.ToList();
        }

        public void EliminarDoctor(int id)
        {
            DOCTOR dato = (from doc in contexto.DOCTOR
                           where doc.DOCTOR_NO == id.ToString()
                           select doc).First();
            contexto.DOCTOR.DeleteOnSubmit(dato);
            contexto.SubmitChanges();                        
                          
        }

        public void InsertarDoctor(String hosCod, String docNum, String ape, String esp, int sal)
        {
            DOCTOR doc = new DOCTOR();
            doc.HOSPITAL_COD = hosCod;
            doc.DOCTOR_NO = docNum;
            doc.APELLIDO = ape;
            doc.ESPECIALIDAD = esp;
            doc.SALARIO = sal;

            contexto.DOCTOR.InsertOnSubmit(doc);
            contexto.SubmitChanges();
        }

        public void ModificarDoctor(String hosCod, String docNum, String ape, String esp, int sal)
        {
            DOCTOR doctor = (from doc in contexto.DOCTOR
                           where doc.DOCTOR_NO == docNum
                           select doc).First();
            doctor.HOSPITAL_COD = hosCod;
            doctor.APELLIDO = ape;
            doctor.ESPECIALIDAD = esp;
            doctor.SALARIO = sal;

            contexto.SubmitChanges();
        }

        public DOCTOR EditarDoctor(int id)
        {
            DOCTOR doctor = (from doc in contexto.DOCTOR
                             where doc.DOCTOR_NO == id.ToString()
                             select doc).First();
            return doctor;
        }

    }
}