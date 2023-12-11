using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScreenLogin.Models
{
    public static class Validacao
    {
        public static List<ValidationResult> getValidationErros(object obj)
        {
            var validationResultList = new List<ValidationResult>();
            var context = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, context, validationResultList, true);
            return validationResultList;
        }
    }
}
