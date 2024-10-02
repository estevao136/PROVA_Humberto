using System.ComponentModel.DataAnnotations;

namespace PROVA_H1.Validation
{
    public class ValidacaoIdade : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Idade não pode ser null");
            }

            int idade = (int)value;

            return idade <= 18 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
