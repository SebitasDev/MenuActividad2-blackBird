using FluentValidation;
using menuActividd2.Models;

namespace menuActividd2.Validators;

public class OrdenProductoValidacion : AbstractValidator<OrdenProducto>
{
    public OrdenProductoValidacion()
    {
        //Validacion de campos nullos
        RuleFor(x => x.OrdenId).NotNull();
        RuleFor(x => x.ProductoId).NotNull();
        RuleFor(x => x.Cantidad).NotNull();
        
        //Validaciones para campos vacios
        string messageRuleEmpty = "El campo {PropertyName} no puede ser vacio";
        RuleFor(x => x.ProductoId).NotEmpty().WithMessage(messageRuleEmpty);
        RuleFor(x => x.OrdenId).NotEmpty().WithMessage(messageRuleEmpty);
    }
}