using ProjetoLocacaoGaragem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        private ValidFields typeField;
        public CustomValidFields(ValidFields type)
        {
            typeField = type;

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaPlaca: return ValidarPlaca(value, validationContext.DisplayName);

                    case ValidFields.ValidaEmail: return ValidarEmail(value, validationContext.DisplayName);

                    case ValidFields.ValidaNomeUsuario: return ValidarNome(value, validationContext.DisplayName);

                    //case ValidFields.ValidaNome: return ValidarNome(value, validationContext.DisplayName);

                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }

        private ValidationResult ValidarEmail(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido!");
        }

        private ValidationResult ValidarNome(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), "^(([a-zA-Z ]|[é])*)$");

            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido!");
        }

        private ValidationResult ValidarPlaca(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), "^(([a-zA-Z ]|[é])*)$");

            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido!");
        }

    }
}