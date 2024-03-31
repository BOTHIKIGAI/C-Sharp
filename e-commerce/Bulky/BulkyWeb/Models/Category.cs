using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {

        // Columnas
        [Key] // Data Anotation o Anotación de información (definir información de base de datos)
        public int Id { get; set; } // Llave primaria de la tabla
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; } // Columna Name
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; } // Si tenemos muchas categorias deberiamos definir en que orden mostrar
    }
}
