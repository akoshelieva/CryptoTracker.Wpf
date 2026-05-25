public class Coin
{
    public int CoinId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string CoinCode { get; set; } = string.Empty;
    public decimal CurrentPrice { get; set; }
    public decimal TotalVolume { get; set; }
    public decimal PriceChange24hPercentage { get; set; }
    public string CoinImage { get; set; } = string.Empty;
    
}