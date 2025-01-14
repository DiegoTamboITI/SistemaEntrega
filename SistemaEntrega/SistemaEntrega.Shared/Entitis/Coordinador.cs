using System.ComponentModel.DataAnnotations;

namespace SistemaEntrega.Shared.Entitis
{
    public class Coordinador
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }
    }
}