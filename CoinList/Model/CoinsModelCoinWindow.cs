using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinList.Model
{
    public class CoinsModelCoinWindow
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("market_data")]
        public MarketData MarketData { get; set; }

    }

    public class MarketData
    {
        [JsonProperty("current_price")]
        public Dictionary<string, float> CurrentPrice { get; set; }

        [JsonProperty("market_cap")]
        public Dictionary<string, float> MarketCap { get; set; }

        [JsonProperty("total_volume")]
        public Dictionary<string, float> TotalVolume { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public float PriceChangePercentage24h { get; set; }

        [JsonProperty("price_change_percentage_7d")]
        public float PriceChangePercentage7d { get; set; }

        [JsonProperty("price_change_percentage_14d")]
        public float PriceChangePercentage14d { get; set; }

        [JsonProperty("price_change_percentage_30d")]
        public float PriceChangePercentage30d { get; set; }

        [JsonProperty("price_change_percentage_60d")]
        public float PriceChangePercentage60d { get; set; }

        [JsonProperty("price_change_percentage_200d")]
        public float PriceChangePercentage200d { get; set; }

        [JsonProperty("price_change_percentage_1y")]
        public float PriceChangePercentage1y { get; set; }
    }
}