using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class UploadFile
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
