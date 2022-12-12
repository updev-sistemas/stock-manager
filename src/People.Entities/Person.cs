namespace UpDEV.StockManager.People.Entities
{
    public class Person : EntityBase
    {
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? Phone { get; set; }
        public virtual string? Document { get; set; }
        public virtual string? DocumentHash { get; set; }
        public virtual DateTime? Birthday { get; set; }
        public virtual IEnumerable<PersonAddress>? Addresses { get; set; }
    }
}