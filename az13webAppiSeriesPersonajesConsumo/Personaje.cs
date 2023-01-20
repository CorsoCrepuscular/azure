using Newtonsoft.Json;

namespace Az13ApiSeriesPersonajesConsumo.Models
{
    public class Personaje
    {
        [JsonProperty("idPersonaje")]
        public int IdPersonaje { get; set; }

        [JsonProperty("nombre")]
        public String Nombre { get; set; }

        [JsonProperty("imagen")]
        public String Imagen { get; set; }

        [JsonProperty("idSerie")]
        public int IdSerie { get; set; }

    }
}
