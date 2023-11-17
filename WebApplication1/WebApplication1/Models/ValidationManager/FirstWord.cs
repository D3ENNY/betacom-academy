using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ValidationManager
{
    public class FirstWord : ValidationAttribute
    {
        private readonly string[] validWords;
        public FirstWord(params string[] validWords) => this.validWords = validWords;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string inputString)
            {
                string firstWord = inputString.Split(' ').FirstOrDefault();

                if (firstWord != null && validWords.Contains(firstWord, StringComparer.OrdinalIgnoreCase))
                    return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "The first value does not match to the input value");
        }
    }
}
