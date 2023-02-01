using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiControlStack.Validations;

namespace WebApiControlStack.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "char(1)")]
        [LineaProductoSoloAceptaHySAttribute]
        public string LineaProducto { get; set; }

        [Column(TypeName ="money")]
        [PrecioMayorACeroAttribute]
        public int Precio { get; set; }
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]

        public Categoria Categoria { get; set; }

    }
}
