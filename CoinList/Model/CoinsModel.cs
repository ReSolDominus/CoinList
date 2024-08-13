using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinList.Model
{

    public class CoinData
    {
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("price_btc")]
        public string PriceBtc { get; set; }
        [JsonProperty("price_change_percentage_24h")]
        public Dictionary<string, double> PriceChangePercentage24H { get; set; }
        [JsonProperty("market_cap")]
        public string MarketCap { get; set; }
        [JsonProperty("market_cap_btc")]
        public string MarketCapBtc { get; set; }
        [JsonProperty("total_volume")]
        public string TotalVolume { get; set; }
        [JsonProperty("total_volume_btc")]
        public string TotalVolumeBtc { get; set; }
        [JsonProperty("sparkline")]
        public string Sparkline { get; set; }
        [JsonProperty("content")]
        public Content Content { get; set; }
    }

    public class Content
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("coin_id")]
        public int CoinId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }
        [JsonProperty("thumb")]
        public string Thumb { get; set; }
        [JsonProperty("small")]
        public string Small { get; set; }
        [JsonProperty("large")]
        public string Large { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("price_btc")]
        public double PriceBtc { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
        [JsonProperty("data")]
        public CoinData Data { get; set; }
    }

    public class Coin
    {
        public Item Item { get; set; }
    }

    public class CoinsModel
    {
        public List<Coin> Coins { get; set; }
    }
}
