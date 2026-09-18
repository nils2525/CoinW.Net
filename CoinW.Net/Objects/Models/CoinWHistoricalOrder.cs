using CoinW.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace CoinW.Net.Objects.Models
{
    /// <summary>
    /// Historical spot order. Monetary totals may be rounded; use user trades for individual fills.
    /// </summary>
    public record CoinWHistoricalOrder
    {
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public long OrderId { get; set; }
        /// <summary>
        /// ["<c>date</c>"] Order creation time in UTC
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>side</c>"] Order side
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Native order type: LIMIT, MARKET, HL_LIMIT, PLANNING, STOP_LIMIT_ORDER, SMART_MARKET_ORDER or ICEBERG
        /// </summary>
        [JsonPropertyName("type")]
        public string OrderType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>dealSize</c>"] Quantity filled in base asset
        /// </summary>
        [JsonPropertyName("dealSize")]
        public decimal QuantityFilled { get; set; }
        /// <summary>
        /// ["<c>dealFunds</c>"] Quantity filled in quote asset
        /// </summary>
        [JsonPropertyName("dealFunds")]
        public decimal QuoteQuantityFilled { get; set; }
        /// <summary>
        /// ["<c>dealAvgPrice</c>"] Average fill price
        /// </summary>
        [JsonPropertyName("dealAvgPrice")]
        public decimal AveragePrice { get; set; }
        /// <summary>
        /// ["<c>fee</c>"] Order fee
        /// </summary>
        [JsonPropertyName("fee")]
        public decimal Fee { get; set; }
        /// <summary>
        /// ["<c>size</c>"] Order quantity in base asset
        /// </summary>
        [JsonPropertyName("size")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>price</c>"] Order price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>status</c>"] Native status: 1 unfilled, 2 partially filled, 3 filled, 4 canceled, 5 triggered, 6 trigger failed
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
    }
}
