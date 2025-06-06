using CryptoExchange.Net.Converters.SystemTextJson;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GateIo.Net.Objects.Models
{
    /// <summary>
    /// Cross margin account
    /// </summary>
    [SerializationModel]
    public record GateIoCrossMarginAccount
    {
        /// <summary>
        /// User id
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// Locked
        /// </summary>
        [JsonPropertyName("locked")]
        public bool Locked { get; set; }
        /// <summary>
        /// Total value in USD
        /// </summary>
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        /// <summary>
        /// Borrowed value in USD
        /// </summary>
        [JsonPropertyName("borrowed")]
        public decimal Borrowed { get; set; }
        /// <summary>
        /// Interest value in USD
        /// </summary>
        [JsonPropertyName("interest")]
        public decimal Interest { get; set; }
        /// <summary>
        /// Risk rate
        /// </summary>
        [JsonPropertyName("risk")]
        public decimal Risk { get; set; }
        /// <summary>
        /// Total initial margin
        /// </summary>
        [JsonPropertyName("total_initial_margin")]
        public decimal TotalInitialMargin { get; set; }
        /// <summary>
        /// Total margin balance
        /// </summary>
        [JsonPropertyName("total_margin_balance")]
        public decimal TotalMarginBalance { get; set; }
        /// <summary>
        /// Total maintenance margin
        /// </summary>
        [JsonPropertyName("total_maintenance_margin")]
        public decimal TotalMaintenanceMargin { get; set; }
        /// <summary>
        /// Total initial margin rate
        /// </summary>
        [JsonPropertyName("total_initial_margin_rate")]
        public decimal TotalInitialMarginRate { get; set; }
        /// <summary>
        /// Total maintenance margin rate
        /// </summary>
        [JsonPropertyName("total_maintenance_margin_rate")]
        public decimal TotalMaintenanceMarginRate { get; set; }
        /// <summary>
        /// Total available margin
        /// </summary>
        [JsonPropertyName("total_available_margin")]
        public decimal TotalAvailableMargin { get; set; }
        /// <summary>
        /// Total amount of the portfolio margin account
        /// </summary>
        [JsonPropertyName("portfolio_margin_total")]
        public decimal PortfolioMarginTotal { get; set; }
        /// <summary>
        /// Total liabilities of the portfolio margin account
        /// </summary>
        [JsonPropertyName("portfolio_margin_total_liab")]
        public decimal PortfolioMarginTotalLiabilities { get; set; }
        /// <summary>
        /// Total equity of the portfolio margin account
        /// </summary>
        [JsonPropertyName("portfolio_margin_total_equity")]
        public decimal PortfolioMarginTotalEquity { get; set; }
        /// <summary>
        /// Balances
        /// </summary>
        [JsonPropertyName("balances")]
        public Dictionary<string, GateIoCrossMarginAccountBalance> Balances { get; set; } = new Dictionary<string, GateIoCrossMarginAccountBalance>();
    }

    /// <summary>
    /// Unified account balance
    /// </summary>
    [SerializationModel]
    public record GateIoCrossMarginAccountBalance
    {
        /// <summary>
        /// Available quantity
        /// </summary>
        [JsonPropertyName("available")]
        public decimal Available { get; set; }
        /// <summary>
        /// Frozen quantity
        /// </summary>
        [JsonPropertyName("freeze")]
        public decimal Frozen { get; set; }
        /// <summary>
        /// Borrowed quantity
        /// </summary>
        [JsonPropertyName("borrowed")]
        public decimal Borrowed { get; set; }
        /// <summary>
        /// Interest
        /// </summary>
        [JsonPropertyName("interest")]
        public decimal Interest { get; set; }
        /// <summary>
        /// Negative liabilities
        /// </summary>
        [JsonPropertyName("negative_liab")]
        public decimal NegativeLiabilities { get; set; }
        /// <summary>
        /// Borrowing to open futures positions
        /// </summary>
        [JsonPropertyName("futures_pos_liab")]
        public decimal FuturesPositionLiabilities { get; set; }
        /// <summary>
        /// Equity
        /// </summary>
        [JsonPropertyName("equity")]
        public decimal Equity { get; set; }
        /// <summary>
        /// Total frozen
        /// </summary>
        [JsonPropertyName("total_freeze")]
        public decimal TotalFrozen { get; set; }
        /// <summary>
        /// Total liabilities
        /// </summary>
        [JsonPropertyName("total_liab")]
        public decimal TotalLiabilities { get; set; }
    }
}
