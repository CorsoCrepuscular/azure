using az13ApiSeriesPersonajes.Data;
using az13ApiSeriesPersonajes.Models;

namespace az13ApiSeriesPersonajes.Repositories
{
    public class RepositorySeries
    {
        SeriesContext context;
        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public List<Serie> GetSeries()
        {
            return this.context.Series.ToList();
        }

        public Serie BuscarSerie(int numSerie){
            return this.context.Series.SingleOrDefault
            (x => x.IdSerie == numSerie);
        }

        public void InsertarSerie (int numS, String nomS, String imaS,
            double punS, int anyS)
        {
            Serie serie= new Serie();   
            serie.IdSerie = numS;
            serie.Nombre = nomS;
            serie.Imagen = imaS;
            serie.Puntuacion = punS;
            serie.Año= anyS;
            this.context.Series.Add(serie);
            this.context.SaveChanges();
        }

        public void ModificarSerie(int numS, String nomS, String imaS,
            double punS, int anyS)
        {
            Serie serie= this.BuscarSerie(numS);
            serie.Nombre = nomS;
            serie.Imagen = imaS;
            serie.Puntuacion = punS;
            serie.Año = anyS;
            this.context.SaveChanges();
        }

        public void BorrarSerie (int numS)
        {
            Serie serie = this.BuscarSerie(numS);
            this.context.Series.Remove(serie);
            this.context.SaveChanges();
        }
    }
}
