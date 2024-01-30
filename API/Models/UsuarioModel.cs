using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("usuarios", Schema = "usuarios")]
    public class UsuarioModel
    {
        //TODO Buscar manera de no ser keysenstitive
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string correo { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public DateTime fecha_creacion { get; set; }
        [Required]
        public DateTime fecha_modificacion { get; set; }
        [Required]
        public int tipo_usuario_id { get; set; }

    }
}