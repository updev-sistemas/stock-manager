namespace UpDEV.StockManager.People.Entities
{
    public class EntityBase : ISystemEntityBase
    {
        public virtual long? Id { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
        public virtual string? IntegrationCode { get; set; }
    }
}
