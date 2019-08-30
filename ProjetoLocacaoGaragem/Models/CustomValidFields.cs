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
        ContextDB dB = new ContextDB();

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

                    case ValidFields.ValidaStatus: return ValidarStatus(value, validationContext);

                    default:
                        break;
                }

            }


            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
        }


        private ValidationResult ValidarEmail(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

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


            bool result = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$") || //PlacaBR
                     Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$") || //Mercosul
                     Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$"); //Moto
            if (result)
            {
                Locacao locacao = dB.Locacaos.FirstOrDefault(x => x.Placa == value.ToString());
                if (locacao == null)
                    return ValidationResult.Success;
                else


                    return new ValidationResult($"Este campo {displayFields} já está cadastrado na nossa base de dados!");
            }
            return new ValidationResult($"A {displayFields} não está no formato aceitável!");
        }

        private ValidationResult ValidarStatus(object value, ValidationContext validationContext)
        {
            Locacao locacao = (Locacao)validationContext.ObjectInstance;
            if (locacao.AceitaTermo)
            {
                locacao.Status = (int)ValidaStatus.FilaDeEspera;
                return ValidationResult.Success;
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é inválido!");
        }
    }
}