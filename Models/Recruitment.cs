using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class Recruitment
    {
        [JsonPropertyName("vacancy")]
        public int Vacancy { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("files")]
        public int[] Files { get; set; }
    }
}
