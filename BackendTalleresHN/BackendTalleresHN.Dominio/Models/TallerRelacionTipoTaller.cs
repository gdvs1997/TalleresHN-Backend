using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackendTalleresHN.Dominio.Models
{
    public class TallerRelacionTipoTaller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int TallerId { get; set; }
        public Taller Taller { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int TipoTallerId { get; set; }
        public TipoTaller TipoTaller { get; set; }
    }
}
