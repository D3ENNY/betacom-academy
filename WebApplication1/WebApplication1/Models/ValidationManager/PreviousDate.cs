using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ValidationManager
{
    public class PreviousDate : ValidationAttribute
    {
        private readonly bool prev;
        public PreviousDate(bool prev) => this.prev = prev;

        public PreviousDate() => throw new NotImplementedException();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool? result = null;
            DateTime date = Convert.ToDateTime(value);

            if (prev)
                result = date <= DateTime.Now;
            else
                result = date >= DateTime.Now;

            if (result == true)
                return ValidationResult.Success;
            return new ValidationResult(ErrorMessage);
        }
    }
}
