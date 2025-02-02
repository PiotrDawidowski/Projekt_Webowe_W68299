using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProjektKrypto2.Components.Models
{
    public class Crypto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("rank")]
        public string Rank { get; set; } = string.Empty;

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("priceUsd")]
        public string PriceUsd { get; set; } = "0";

        [JsonPropertyName("changePercent24Hr")]
        public string ChangePercent24Hr { get; set; } = "0";

        [JsonPropertyName("volumeUsd24Hr")] // ✅ Dodane, aby naprawić błąd CS1061!
        public string VolumeUsd24Hr { get; set; } = "0";

        public string GetIconUrl()
        {
            return $"https://assets.coincap.io/assets/icons/{Symbol.ToLower()}@2x.png";
        }
    }

    public class CryptoResponse
    {
        [JsonPropertyName("data")]
        public List<Crypto> Data { get; set; } = new();
    }
}
