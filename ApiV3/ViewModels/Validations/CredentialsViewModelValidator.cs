using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epta.API.ViewModels.Validations
{
    public class CredentialsViewModelValidator : AbstractValidator<CredentialsViewModel>
    {
        public CredentialsViewModelValidator()
        {
            RuleFor(vm => vm.Login).NotEmpty().WithMessage("Campo Login é obrigatório");
            RuleFor(vm => vm.Senha).NotEmpty().WithMessage("Campo Senha é obrigatório");
            //RuleFor(vm => vm.Password).Length(6, 12).WithMessage("Campo Senha deve possuir de 6 à 12 dígitos");
        }
    }
}
