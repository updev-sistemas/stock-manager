namespace UpDEV.StockManager.People.Entities
{
    public class PersonAddress : EntityBase
    {
        public virtual Person? Owner { get; set; }
        public virtual string? AliasForName { get; set; }
        public virtual string? Streatname { get; set; }
        public virtual string? Number { get; set; }
        public virtual string? District { get; set; }
        public virtual string? Postcode { get; set; }
        public virtual string? Complement { get; set; }
        public virtual string? City { get; set; }
        public virtual string? State { get; set; }
    }
}
