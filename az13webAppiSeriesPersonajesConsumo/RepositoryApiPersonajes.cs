using Newtonsoft.Json;
using System.Net.Http.Headers;
using Az13ApiSeriesPersonajesConsumo.Models;

namespace Az13ApiSeriesPersonajesConsumo.Repositories
{
    public class RepositoryApiPersonajes
    {
        private String uriapi;
        private MediaTypeWithQualityHeaderValue headerjson;
        public RepositoryApiPersonajes()
        {
            this.uriapi = "https://az13webapiseries.azurewebsites.net";
            this.headerjson = new
                MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<List<Personaje>> GetPersonajesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Personajes";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Personaje> personajes =
                    await response.Content.ReadAsAsync<List<Personaje>>();
                    return personajes;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<Personaje> BuscarPersonajeAsync(int numPer)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Personajes/" + numPer;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await
                    client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Personaje personaje =
                    await response.Content.ReadAsAsync<Personaje>();
                    return personaje;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task InsertarPersonajeAsync(int idP, String nomP, String imaP, int idS)

        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Personajes";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Personaje personaje = new Personaje();
                personaje.IdPersonaje = idP;
                personaje.Nombre= nomP;
                personaje.Imagen= imaP;
                personaje.IdSerie= idS;
                String json = JsonConvert.SerializeObject(personaje);
                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
               
            }
        }

        public async Task ModificarPersonajeAsync(int idP, String nomP, String imaP, int idS)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Personajes/" + idP;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                Personaje personaje = new Personaje();
                personaje.IdPersonaje = idP;
                personaje.Nombre = nomP;
                personaje.Imagen = imaP;
                personaje.IdSerie = idS;
                String json = JsonConvert.SerializeObject(personaje);

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);
            }
        }

        public async Task EliminarPersonajeAsync(int numPer)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Personajes/" + numPer;
                //String peticion = "api/EliminarDatos/14/AAA";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);
            }
        }
    }
}
