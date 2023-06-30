using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_desafio21dias_administradores.Models
{
    [Table("Administradores")]
    public class Administrador
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Column("email", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Column("senha", TypeName = "varchar")]
        [Required]
        [MaxLength(10)]
        public int Senha { get; set; }
    }
}
