public class CoinDetails
{
    public string CoinId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string CoinCode { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal CurrentPrice { get; set; }
    public decimal TotalVolume { get; set; }
    public decimal PriceChange24hPercentage { get; set; }
    
}