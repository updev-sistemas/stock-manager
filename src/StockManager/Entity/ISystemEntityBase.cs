namespace UpDEV.StockManager
{
    public interface ISystemEntityBase
    {
        long? Id { get; set; }
        DateTime? CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        string? IntegrationCode { get; set; }
    }
}