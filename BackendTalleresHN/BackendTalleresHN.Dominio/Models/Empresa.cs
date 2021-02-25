using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackendTalleresHN.Dominio.Models
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string NombreEmpresa { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string NombreDueño { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Direccion { get; set; }
        public float Longitud { get; set; }
        public float Latitud { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime FechaInscripcion { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public bool Estado { get; set; }
    }
}
