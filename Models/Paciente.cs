using System.ComponentModel.DataAnnotations;

namespace MateoJijon_Examen1P.Models
{
    public class Paciente
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public String? Nombre { get; set;}
        [Required]
        public String? Apellido { get; set;}
        [Range(1, 100)]
        public decimal Precio { get; set;}
        public bool Especialidad { get; set;}

        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set;}

        [StringLength(100)]
        public String? Descripcion { get; set;}
        
        
        [RegularExpression(@"^[A-Z]{3}-\d{3}$")]
        public String? CodigoUnico { get; set;}
       

    }
    
}
