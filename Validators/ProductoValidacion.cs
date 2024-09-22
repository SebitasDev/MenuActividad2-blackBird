using FluentValidation;
using menuActividd2.Models;

namespace menuActividd2.Validators;

public class ProductoValidacion : AbstractValidator<Producto>
{
    public ProductoValidacion()
    {
        //Validacion de campos nullos
        RuleFor(x => x.Nombre).NotNull();
        RuleFor(x => x.Descripcion).NotNull();
        RuleFor(x => x.Precio).NotNull();
        
        //Validaciones para campos vacios
        string messageRuleEmpty = "El campo {PropertyName} no puede ser vacio";
        RuleFor(x => x.Nombre).NotEmpty().WithMessage(messageRuleEmpty);
        RuleFor(x => x.Descripcion).NotEmpty().WithMessage(messageRuleEmpty);
        RuleFor(x => x.Precio).NotEmpty().WithMessage(messageRuleEmpty);
        
        //Validaciones para longitud
        RuleFor(x => x.Nombre).MaximumLength(80);
    }
}