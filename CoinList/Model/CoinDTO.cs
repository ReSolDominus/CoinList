using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CoinList.Model
{
    [DataContract]
    public class CoinDTO
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "market_data")]
        public MarketData MarketData { get; set; }

    }

    [DataContract]
    public class MarketData
    {
        [DataMember(Name = "current_price")]
        public Dictionary<string, float> CurrentPrice { get; set; }

        [DataMember(Name = "market_cap")]
        public Dictionary<string, float> MarketCap { get; set; }

        [DataMember(Name = "total_volume")]
        public Dictionary<string, float> TotalVolume { get; set; }

        [DataMember(Name = "price_change_percentage_24h")]
        public float PriceChangePercentage24Hours { get; set; }

        [DataMember(Name = "price_change_percentage_7d")]
        public float PriceChangePercentage7Days { get; set; }

        [DataMember(Name = "price_change_percentage_14d")]
        public float PriceChangePercentage14Days { get; set; }

        [DataMember(Name = "price_change_percentage_30d")]
        public float PriceChangePercentage30Days { get; set; }

        [DataMember(Name = "price_change_percentage_60d")]
        public float PriceChangePercentage60Days { get; set; }

        [DataMember(Name = "price_change_percentage_200d")]
        public float PriceChangePercentage200Days { get; set; }

        [DataMember(Name = "price_change_percentage_1y")]
        public float PriceChangePercentage1Year { get; set; }
    }
}