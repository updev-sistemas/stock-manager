namespace UpDEV.StockManager.People.Entities
{
    public class Supplier : Person
    {
        public virtual string? CorporateDocument { get; set; }
        public virtual string? CorporateDocumentHash { get; set; }
    }
}
