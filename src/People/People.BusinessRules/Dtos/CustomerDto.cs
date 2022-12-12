namespace UpDEV.StockManager.People.BusinessRules.Dtos
{
    public class CustomerDto
    {
        public virtual string? IntegrationCode { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? Phone { get; set; }
        public virtual string? Document { get; set; }
        public virtual string? DocumentHash { get; set; }
        public virtual DateTime? Birthday { get; set; }
        public virtual IEnumerable<PersonAddressDto>? Addresses { get; set; }
    }
}
