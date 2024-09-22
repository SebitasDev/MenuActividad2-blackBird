using FluentValidation;
using menuActividd2.Models;

namespace menuActividd2.Validators;

public class OrdenValidacion : AbstractValidator<Orden>
{
    public OrdenValidacion()
    {
        //Validacion de campos nullos
        RuleFor(x => x.UsuarioId).NotNull();
        RuleFor(x => x.Fecha_Orden).NotNull();
        
        //Validaciones para campos vacios
        string messageRuleEmpty = "El campo {PropertyName} no puede ser vacio";
        RuleFor(x => x.UsuarioId).NotEmpty().WithMessage(messageRuleEmpty);
    }
}