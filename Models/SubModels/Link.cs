using System;
using System.Text.Json.Serialization;

namespace HuntflowLib.Models.SubModels
{
    public class Link
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("changed")]
        public DateTime Changed { get; set; }

        [JsonPropertyName("vacancy")]
        public int Vacancy { get; set; }
    }
}
