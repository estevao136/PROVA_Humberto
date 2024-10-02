using System.ComponentModel.DataAnnotations;

namespace PROVA_H1.Validation
{
    public class ValidacaoBebida : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult(" Insira sua bebida!");
            }

            string carta = (string)value;

            return carta.Length <= 500 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
