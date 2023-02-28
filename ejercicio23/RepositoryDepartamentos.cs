using MvcDockersMySqlV6.Data;
using MvcDockersMySqlV6.Models;

namespace MvcDockersMySqlV6.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public Departamento FindDepartamento(int id)
        {
            return this.context.Departamentos.SingleOrDefault(x => x.IdDepartamento == id);
        }

        public void EditDepartamento(int id, string nom, string loc) 
        {
            Departamento dep = this.FindDepartamento(id);
;           dep.Nombre = nom;
            dep.Localidad = loc;
            this.context.SaveChanges();         
        }

        public void InsertarDepartamento(int id, string nom, string loc)
        {
            Departamento dep = new Departamento();
            dep.IdDepartamento = id;
            dep.Nombre = nom;
            dep.Localidad = loc;
            this.context.Departamentos.Add(dep);
            this.context.SaveChanges();

        }

        public void EliminarDepartamento(int id)
        {
            Departamento dep = this.FindDepartamento(id);
            this.context.Departamentos.Remove(dep);
            this.context.SaveChanges();
        }
    }
}
