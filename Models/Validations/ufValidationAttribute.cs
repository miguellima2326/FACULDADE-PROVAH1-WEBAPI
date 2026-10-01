using System.ComponentModel.DataAnnotations;

namespace miguelprovaapi.Models.Validations
{
    public class ufValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string uf = value as string;

            if (string.IsNullOrEmpty(uf))
                return new ValidationResult("A UF é obrigatória.");

            if (uf.Length != 2)
                return new ValidationResult("A UF deve ter exatamente 2 caracteres.");
        
            if (uf != "MG" || uf != "SP" || uf != "RJ" || uf != "ES")
                return new ValidationResult("O Eleitor ausente deve ter alguma dessa uf 'MG, SP, RJ ou ES'");

            return ValidationResult.Success;
        }
    }
}