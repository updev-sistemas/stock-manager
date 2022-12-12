using FluentNHibernate.Mapping;
using UpDEV.StockManager.People.Entities;

namespace UpDEV.StockManager.People.Data.Mapping
{
    public class SupplierMap : ClassMap<Supplier>
    {
        public SupplierMap()
        {
            Table("");
            
            Id(p => p.Id).Column("id").GeneratedBy.Identity();
            Map(p => p.IntegrationCode).Column("integration_code").Unique().Nullable();
            Map(p => p.CreatedAt).Column("created_at").Nullable();
            Map(p => p.UpdatedAt).Column("updated_at").Nullable();

        }
    }
}
