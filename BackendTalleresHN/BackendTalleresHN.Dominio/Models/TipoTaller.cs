using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackendTalleresHN.Dominio.Models
{
    public class TipoTaller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Descripcion { get; set; }
        public List<TallerRelacionTipoTaller> TallerRelacionesTipoTaller { get; set; }
    }
}
