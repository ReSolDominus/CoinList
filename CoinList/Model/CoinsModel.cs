using System.Collections.Generic;

namespace CoinList.Model
{

    public class CoinData
    {
        public double Price { get; set; }
        public string PriceBtc { get; set; }
        public Dictionary<string, double> PriceChangePercentage24H { get; set; }
        public string MarketCap { get; set; }
        public string MarketCapBtc { get; set; }
        public string TotalVolume { get; set; }
        public string TotalVolumeBtc { get; set; }
        public string Sparkline { get; set; }
        public Content Content { get; set; }
    }

    public class Content
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Item
    {
        public string Id { get; set; }
        public int CoinId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int MarketCapRank { get; set; }
        public string Thumb { get; set; }
        public string Small { get; set; }
        public string Large { get; set; }
        public string Slug { get; set; }
        public double PriceBtc { get; set; }
        public int Score { get; set; }
        public CoinData Data { get; set; }
    }

    public class Coin
    {
        public Item Item { get; set; }
    }

    class CoinsModel
    {
        public List<Coin> Coins { get; set; }
    }
}
