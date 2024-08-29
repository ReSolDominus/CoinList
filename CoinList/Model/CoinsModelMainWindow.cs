using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinList.Model
{

    public class CoinData
    {
        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public Dictionary<string, double> PriceChangePercentage24Hours { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("coin_id")]
        public int CoinId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
        [JsonProperty("data")]
        public CoinData Data { get; set; }
    }

    public class Coin
    {
        public Item Item { get; set; }
    }

    public class CoinsModelMainWindow
    {
        public List<Coin> Coins { get; set; }
    }
}
