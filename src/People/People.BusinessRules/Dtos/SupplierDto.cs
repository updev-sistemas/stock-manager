namespace UpDEV.StockManager.People.BusinessRules.Dtos
{
    public class SupplierDto
    {
        public virtual string? IntegrationCode { get; set; }
        public virtual PersonDto? Person { get; set; }
        public virtual string? CorporateDocument { get; set; }
        public virtual string? CorporateDocumentHash { get; set; }
    }
}
