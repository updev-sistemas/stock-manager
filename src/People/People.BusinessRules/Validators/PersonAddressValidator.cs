using FluentValidation;
using UpDEV.StockManager.People.BusinessRules.Dtos;

namespace UpDEV.StockManager.People.BusinessRules.Validators
{
    public class PersonAddressValidator : AbstractValidator<PersonAddressDto>
    {
        public PersonAddressValidator()
        {
            this.RuleSet("person-address-create", () =>
            {
                this.RuleFor(p => p.IntegrationCode).NotEmpty().MaximumLength(60);
                this.RuleFor(p => p.PersonIntegrationCode).NotEmpty().MaximumLength(60);
                this.RuleFor(p => p.AliasForName).NotEmpty().MinimumLength(2).MaximumLength(60);
                this.RuleFor(p => p.Streatname).NotEmpty().MaximumLength(300);
                this.RuleFor(p => p.Number).NotEmpty().MinimumLength(1).MaximumLength(20);
                this.RuleFor(p => p.District).NotEmpty().MinimumLength(2).MaximumLength(50);
                this.RuleFor(p => p.Postcode).NotEmpty().MinimumLength(2).MaximumLength(30);
                this.RuleFor(p => p.Complement).NotEmpty().MaximumLength(180);
                this.RuleFor(p => p.City).NotEmpty().MinimumLength(2).MaximumLength(100);
                this.RuleFor(p => p.State).NotEmpty().MinimumLength(2).MaximumLength(30);
            });

            this.RuleSet("person-address-put", () =>
            {
                this.RuleFor(p => p.IntegrationCode).NotEmpty().MaximumLength(60);
                this.RuleFor(p => p.PersonIntegrationCode).NotEmpty().MaximumLength(60);
                this.RuleFor(p => p.AliasForName).NotEmpty().MinimumLength(2).MaximumLength(60);
                this.RuleFor(p => p.Streatname).NotEmpty().MaximumLength(300);
                this.RuleFor(p => p.Number).NotEmpty().MinimumLength(1).MaximumLength(20);
                this.RuleFor(p => p.District).NotEmpty().MinimumLength(2).MaximumLength(50);
                this.RuleFor(p => p.Postcode).NotEmpty().MinimumLength(2).MaximumLength(30);
                this.RuleFor(p => p.Complement).NotEmpty().MaximumLength(180);
                this.RuleFor(p => p.City).NotEmpty().MinimumLength(2).MaximumLength(100);
                this.RuleFor(p => p.State).NotEmpty().MinimumLength(2).MaximumLength(30);
            });

            this.RuleSet("person-address-patch", () =>
            {
                this.RuleFor(p => p.IntegrationCode).NotEmpty().MaximumLength(60).When(p => !string.IsNullOrEmpty(p.IntegrationCode));
                this.RuleFor(p => p.PersonIntegrationCode).NotEmpty().MaximumLength(60).When(p => !string.IsNullOrEmpty(p.PersonIntegrationCode));
                this.RuleFor(p => p.AliasForName).NotEmpty().MinimumLength(2).MaximumLength(60).When(p => !string.IsNullOrEmpty(p.AliasForName));
                this.RuleFor(p => p.Streatname).NotEmpty().MaximumLength(300).When(p => !string.IsNullOrEmpty(p.Streatname));
                this.RuleFor(p => p.Number).NotEmpty().MinimumLength(1).MaximumLength(20).When(p => !string.IsNullOrEmpty(p.Number));
                this.RuleFor(p => p.District).NotEmpty().MinimumLength(2).MaximumLength(50).When(p => !string.IsNullOrEmpty(p.District));
                this.RuleFor(p => p.Postcode).NotEmpty().MinimumLength(2).MaximumLength(30).When(p => !string.IsNullOrEmpty(p.Postcode));
                this.RuleFor(p => p.Complement).NotEmpty().MaximumLength(180).When(p => !string.IsNullOrEmpty(p.Complement));
                this.RuleFor(p => p.City).NotEmpty().MinimumLength(2).MaximumLength(100).When(p => !string.IsNullOrEmpty(p.City));
                this.RuleFor(p => p.State).NotEmpty().MinimumLength(2).MaximumLength(30).When(p => !string.IsNullOrEmpty(p.State));
            });
        }
    }
}
