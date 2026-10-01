using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using miguelprovaapi.Models.Validations;

namespace miguelprovaapi.Models
{
    public class EleitorDados
    {
        [Required(ErrorMessage = "O nome do Eleitore é obrigatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome do Eleitor deve ter entre 3 a 50 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatorio.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 digitos.")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O título  é obrigatorio.")]
        [MaxLength(50, ErrorMessage = "O título deve ter no maximo 50 caracteres.")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "A UF é obrigatoria.")]
        [PosicaoValidation(ErrorMessage = "O Eleitor deve ter alguma dessa UF 'MG, SP, RJ ou ES'")]
        public string uf { get; set; }
    }
}
