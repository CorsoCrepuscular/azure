using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace az13ApiSeriesPersonajes.Models
{
    /* "idSerie", "nombre", "imagen", "puntuacion", "anyo" */
    [Table("SERIES")]
    public class Serie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDSERIE")]
        public int IdSerie { get; set; }

        [Column("NOMBRE")]
        public String Nombre { get; set; }

        [Column("IMAGEN")]
        public String Imagen { get; set; }

        [Column("PUNTUACION")]
        public double Puntuacion{ get; set; }

        [Column("ANYO")]
        public int Anyo { get; set; }

    }
}
