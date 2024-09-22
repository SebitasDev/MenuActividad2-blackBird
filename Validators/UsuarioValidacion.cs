using FluentValidation;
using menuActividd2.Models;

namespace menuActividd2.Validators;

public class UsuarioValidacion : AbstractValidator<Usuario>
{
    public UsuarioValidacion()
    {
        //Validacion de campos nullos
        RuleFor(x => x.Nombres).NotNull();
        RuleFor(x => x.Correo).NotNull();
        RuleFor(x => x.Apellidos).NotNull();
        
        //Validaciones para campos vacios
        string messageRuleEmpty = "El campo {PropertyName} no puede ser vacio";
        RuleFor(x => x.Nombres).NotEmpty().WithMessage(messageRuleEmpty);
        RuleFor(x => x.Apellidos).NotEmpty().WithMessage(messageRuleEmpty);
        RuleFor(x => x.Correo).NotEmpty().WithMessage(messageRuleEmpty);

        //Validaciones para longitud
        RuleFor(x => x.Nombres).MaximumLength(75);
        RuleFor(x => x.Apellidos).MaximumLength(100);
        RuleFor(x => x.Correo).MaximumLength(80);
        
        //Validaciones especificas
        RuleFor(x => x.Correo).EmailAddress();
    }
}