using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiControlStack.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
