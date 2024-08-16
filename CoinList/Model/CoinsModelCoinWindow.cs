using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinList.Model
{
    public class CoinsModelCoinWindow
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("web_slug")]
        public string WebSlug { get; set; }

        [JsonProperty("asset_platform_id")]
        public string AssetPlatformId { get; set; }

        [JsonProperty("platforms")]
        public Dictionary<string, string> Platforms { get; set; }

        [JsonProperty("detail_platforms")]
        public Dictionary<string, PlatformDetail> DetailPlatforms { get; set; }

        [JsonProperty("block_time_in_minutes")]
        public int BlockTimeInMinutes { get; set; }

        [JsonProperty("hashing_algorithm")]
        public string HashingAlgorithm { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("preview_listing")]
        public bool PreviewListing { get; set; }

        [JsonProperty("public_notice")]
        public string PublicNotice { get; set; }

        [JsonProperty("additional_notices")]
        public List<string> AdditionalNotices { get; set; }

        [JsonProperty("localization")]
        public Dictionary<string, string> Localization { get; set; }

        [JsonProperty("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; }

        [JsonProperty("genesis_date")]
        public string GenesisDate { get; set; }

        [JsonProperty("sentiment_votes_up_percentage")]
        public float SentimentVotesUpPercentage { get; set; }

        [JsonProperty("sentiment_votes_down_percentage")]
        public float SentimentVotesDownPercentage { get; set; }

        [JsonProperty("watchlist_portfolio_users")]
        public int WatchlistPortfolioUsers { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        [JsonProperty("market_data")]
        public MarketData MarketData { get; set; }

        /*[JsonProperty("community_data")]
        public CommunityData CommunityData { get; set; }

        [JsonProperty("developer_data")]
        public DeveloperData DeveloperData { get; set; }

        [JsonProperty("status_updates")]
        public List<object> StatusUpdates { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("tickers")]
        public List<Ticker> Tickers { get; set; }*/
    }

    public class PlatformDetail
    {
        [JsonProperty("decimal_place")]
        public int? DecimalPlace { get; set; }

        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; }
    }

    public class Links
    {
        [JsonProperty("homepage")]
        public List<string> Homepage { get; set; }

        [JsonProperty("whitepaper")]
        public string Whitepaper { get; set; }

        [JsonProperty("blockchain_site")]
        public List<string> BlockchainSite { get; set; }

        [JsonProperty("official_forum_url")]
        public List<string> OfficialForumUrl { get; set; }

        [JsonProperty("chat_url")]
        public List<string> ChatUrl { get; set; }

        [JsonProperty("announcement_url")]
        public List<string> AnnouncementUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("facebook_username")]
        public string FacebookUsername { get; set; }

        [JsonProperty("bitcointalk_thread_identifier")]
        public string BitcointalkThreadIdentifier { get; set; }

        [JsonProperty("telegram_channel_identifier")]
        public string TelegramChannelIdentifier { get; set; }

        [JsonProperty("subreddit_url")]
        public string SubredditUrl { get; set; }

        [JsonProperty("repos_url")]
        public ReposUrl ReposUrl { get; set; }
    }

    public class ReposUrl
    {
        [JsonProperty("github")]
        public List<string> Github { get; set; }

        [JsonProperty("bitbucket")]
        public List<string> Bitbucket { get; set; }
    }

    public class Image
    {
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class MarketData
    {
        [JsonProperty("current_price")]
        public Dictionary<string, float> CurrentPrice { get; set; }

        [JsonProperty("total_value_locked")]
        public object TotalValueLocked { get; set; }

        [JsonProperty("mcap_to_tvl_ratio")]
        public object McapToTvlRatio { get; set; }

        [JsonProperty("fdv_to_tvl_ratio")]
        public object FdvToTvlRatio { get; set; }

        [JsonProperty("roi")]
        public object Roi { get; set; }

        [JsonProperty("ath")]
        public Dictionary<string, float> Ath { get; set; }

        [JsonProperty("ath_date")]
        public Dictionary<string, string> AthDate { get; set; }

        [JsonProperty("atl")]
        public Dictionary<string, float> Atl { get; set; }

        [JsonProperty("atl_change_percentage")]
        public Dictionary<string, float> AtlChangePercentage { get; set; }

        [JsonProperty("atl_date")]
        public Dictionary<string, string> AtlDate { get; set; }

        [JsonProperty("market_cap")]
        public Dictionary<string, float> MarketCap { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        [JsonProperty("fully_diluted_valuation")]
        public Dictionary<string, float> FullyDilutedValuation { get; set; }

        [JsonProperty("market_cap_fdv_ratio")]
        public float MarketCapFdvRatio { get; set; }

        [JsonProperty("total_volume")]
        public Dictionary<string, float> TotalVolume { get; set; }

        [JsonProperty("high_24h")]
        public Dictionary<string, float> High24h { get; set; }

        [JsonProperty("low_24h")]
        public Dictionary<string, float> Low24h { get; set; }

        [JsonProperty("price_change_24h")]
        public float PriceChange24h { get; set; }

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

        [JsonProperty("market_cap_change_24h")]
        public float MarketCapChange24h { get; set; }

        [JsonProperty("market_cap_change_percentage_24h")]
        public float MarketCapChangePercentage24h { get; set; }

        [JsonProperty("price_change_24h_in_currency")]
        public Dictionary<string, float> PriceChange24hInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency")]
        public Dictionary<string, float> PriceChangePercentage1hInCurrency { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency")]
        public Dictionary<string, float> PriceChangePercentage24hInCurrency { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency")]
        public Dictionary<string, float> PriceChangePercentage7dInCurrency { get; set; }

        [JsonProperty("price_change_percentage_14d_in_currency")]
        public Dictionary<string, float> PriceChangePercentage14dInCurrency { get; set; }

        [JsonProperty("price_change_percentage_30d_in_currency")]
        public Dictionary<string, float> PriceChangePercentage30dInCurrency { get; set; }

        [JsonProperty("price_change_percentage_60d_in_currency")]
        public Dictionary<string, float> PriceChangePercentage60dInCurrency { get; set; }

        [JsonProperty("price_change_percentage_200d_in_currency")]
        public Dictionary<string, float> PriceChangePercentage200dInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1y_in_currency")]
        public Dictionary<string, float> PriceChangePercentage1yInCurrency { get; set; }

        [JsonProperty("market_cap_change_24h_in_currency")]
        public Dictionary<string, float> MarketCapChange24hInCurrency { get; set; }

        [JsonProperty("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, float> MarketCapChangePercentage24hInCurrency { get; set; }

        [JsonProperty("total_supply")]
        public float TotalSupply { get; set; }

        [JsonProperty("max_supply")]
        public float MaxSupply { get; set; }

        [JsonProperty("circulating_supply")]
        public float CirculatingSupply { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }
    }

    public class CommunityData
    {
        [JsonProperty("facebook_likes")]
        public int? FacebookLikes { get; set; }

        [JsonProperty("twitter_followers")]
        public int TwitterFollowers { get; set; }

        [JsonProperty("reddit_average_posts_48h")]
        public int RedditAveragePosts48h { get; set; }

        [JsonProperty("reddit_average_comments_48h")]
        public int RedditAverageComments48h { get; set; }

        [JsonProperty("reddit_subscribers")]
        public int RedditSubscribers { get; set; }

        [JsonProperty("reddit_accounts_active_48h")]
        public int RedditAccountsActive48h { get; set; }

        [JsonProperty("telegram_channel_user_count")]
        public int? TelegramChannelUserCount { get; set; }
    }

    public class DeveloperData
    {
        [JsonProperty("forks")]
        public int Forks { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("subscribers")]
        public int Subscribers { get; set; }

        [JsonProperty("total_issues")]
        public int TotalIssues { get; set; }

        [JsonProperty("closed_issues")]
        public int ClosedIssues { get; set; }

        [JsonProperty("pull_requests_merged")]
        public int PullRequestsMerged { get; set; }

        [JsonProperty("pull_request_contributors")]
        public int PullRequestContributors { get; set; }

        [JsonProperty("code_additions_deletions_4_weeks")]
        public CodeAdditionsDeletions CodeAdditionsDeletions4Weeks { get; set; }

        [JsonProperty("commit_count_4_weeks")]
        public int CommitCount4Weeks { get; set; }

        [JsonProperty("last_4_weeks_commit_activity_series")]
        public List<object> Last4WeeksCommitActivitySeries { get; set; }
    }

    public class CodeAdditionsDeletions
    {
        [JsonProperty("additions")]
        public int Additions { get; set; }

        [JsonProperty("deletions")]
        public int Deletions { get; set; }
    }

    public class Ticker
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("market")]
        public Market Market { get; set; }

        [JsonProperty("last")]
        public float Last { get; set; }

        [JsonProperty("volume")]
        public float Volume { get; set; }

        [JsonProperty("converted_last")]
        public Dictionary<string, float> ConvertedLast { get; set; }

        [JsonProperty("converted_volume")]
        public Dictionary<string, float> ConvertedVolume { get; set; }

        [JsonProperty("trust_score")]
        public string TrustScore { get; set; }

        [JsonProperty("bid_ask_spread_percentage")]
        public float BidAskSpreadPercentage { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("last_traded_at")]
        public string LastTradedAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("is_anomaly")]
        public bool IsAnomaly { get; set; }

        [JsonProperty("is_stale")]
        public bool IsStale { get; set; }

        [JsonProperty("trade_url")]
        public string TradeUrl { get; set; }

        [JsonProperty("token_info_url")]
        public string TokenInfoUrl { get; set; }

        [JsonProperty("coin_id")]
        public string CoinId { get; set; }

        [JsonProperty("target_coin_id")]
        public string TargetCoinId { get; set; }
    }

    public class Market
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
    }

}