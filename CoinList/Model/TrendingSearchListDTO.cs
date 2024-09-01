using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CoinList.Model
{
    [DataContract]
    public class TrendingSearchListDTO
    {
        [DataMember(Name = "coins")]
        public List<Coin> Coins { get; set; }
    }

    [DataContract]
    public class Coin
    {
        [DataMember(Name = "item")]
        public Item Item { get; set; }
    }

    [DataContract]
    public class Item
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "coin_id")]
        public int CoinId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }

        [DataMember(Name = "data")]
        public CoinData Data { get; set; }
    }

    [DataContract]
    public class CoinData
    {
        [DataMember(Name = "price")]
        public double Price { get; set; }

        [DataMember(Name = "price_change_percentage_24h")]
        public Dictionary<string, double> PriceChangePercentage24Hours { get; set; }
    }
}
