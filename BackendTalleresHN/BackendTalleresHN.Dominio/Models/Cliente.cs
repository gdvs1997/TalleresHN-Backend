using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackendTalleresHN.Dominio.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public bool Estado { get; set; }
    }
}
