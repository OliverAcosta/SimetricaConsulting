using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructura.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Nombre { get; set; }
        public string Usuario_Transaccion { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Fecha_Transaccion { get; set; }
    }
}
