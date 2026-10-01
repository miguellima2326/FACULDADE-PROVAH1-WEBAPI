using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using miguelprovaapi.Models.Validations;

namespace miguelprovaapi.Models
{
    public class Ausente
    {
        [Required(ErrorMessage = "O CPF é obrigatorio.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 caracteres.")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O Turno é obrigatorio.")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "O Turno deve ter 1 caracter.")]
        public int? turno { get; set; }

        [Required(ErrorMessage = "O motivo é obrigatorio.")]
        [StringLength(500, MinimumLength = 50, ErrorMessage = "O Motivo deve ter entre 50 e 500 caracteres.")]
        public string motivo { get; set; }

        public bool ausente { get; set; }

    }
}
