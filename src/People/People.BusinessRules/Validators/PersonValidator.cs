using FluentValidation;
using UpDEV.StockManager.People.BusinessRules.Dtos;

namespace UpDEV.StockManager.People.BusinessRules.Validators
{
    public class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {
            this.RuleSet("person-create", () =>
            {
                this.RuleFor(p => p.IntegrationCode).NotEmpty().MaximumLength(60);
                this.RuleFor(p => p.Name).NotEmpty().MinimumLength(2).MaximumLength(200);
                this.RuleFor(p => p.Email).NotEmpty().MaximumLength(120).EmailAddress();
                this.RuleFor(p => p.Phone).NotEmpty().MinimumLength(8).MaximumLength(20);
                this.RuleFor(p => p.Document).NotEmpty().MinimumLength(2).MaximumLength(30);
                this.RuleFor(p => p.Birthday).NotEmpty().LessThan(p => DateTime.Now);
                this.RuleForEach(p => p.Addresses).SetValidator(new PersonAddressValidator(), "person-address-create");
            });

            this.RuleSet("person-put", () =>
            {
                this.RuleFor(p => p.IntegrationCode).NotEmpty().MaximumLength(60);
                this.RuleFor(p => p.Name).NotEmpty().MinimumLength(2).MaximumLength(200);
                this.RuleFor(p => p.Email).NotEmpty().MaximumLength(120).EmailAddress();
                this.RuleFor(p => p.Phone).NotEmpty().MinimumLength(8).MaximumLength(20);
                this.RuleFor(p => p.Document).NotEmpty().MinimumLength(2).MaximumLength(30);
                this.RuleFor(p => p.Birthday).NotEmpty().LessThan(p => DateTime.Now).When(p => p.Birthday.HasValue);
                this.RuleForEach(p => p.Addresses).SetValidator(new PersonAddressValidator(), "person-address-put");
            });

            this.RuleSet("person-patch", () =>
            {
                this.RuleFor(p => p.IntegrationCode).NotEmpty().MaximumLength(60).When(p => !string.IsNullOrEmpty(p.IntegrationCode));
                this.RuleFor(p => p.Name).NotEmpty().MinimumLength(2).MaximumLength(200).When(p => !string.IsNullOrEmpty(p.Name));
                this.RuleFor(p => p.Email).NotEmpty().MaximumLength(120).EmailAddress().When(p => !string.IsNullOrEmpty(p.Email));
                this.RuleFor(p => p.Phone).NotEmpty().MinimumLength(8).MaximumLength(20).When(p => !string.IsNullOrEmpty(p.Phone));
                this.RuleFor(p => p.Document).NotEmpty().MinimumLength(2).MaximumLength(30).When(p => !string.IsNullOrEmpty(p.Document));
                this.RuleFor(p => p.Birthday).NotEmpty().LessThan(p => DateTime.Now).When(p => p.Birthday.HasValue);
                this.RuleForEach(p => p.Addresses).SetValidator(new PersonAddressValidator(), "person-address-patch");
            });
        }
    }
}
