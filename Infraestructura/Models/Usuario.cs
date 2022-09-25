using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructura.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Index("Index_unique_01", Order = 1, IsUnique = true)]
        [MaxLength(16)]
        public string Cedula { get; set; }

        [Index("Index_unique_02", Order = 1, IsUnique = true)]
        [MaxLength(200)]
        public string Usuario_Nombre { get; set; }
        public string Contrasena { get; set; }

        [Index()]
        public DateTime? Fecha_Nacimiento { get; set; }

        public string Usuario_Transaccion { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Fecha_Transaccion { get; set; }

        [ForeignKey("RolId")]
        public Role Role { get; set; }
    }
}
