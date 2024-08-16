using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class ListModel<T>
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }

        [JsonPropertyName("items")]
        public IEnumerable<T> Items { get; set; }
    }
}
