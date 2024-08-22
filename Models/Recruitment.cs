using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class Recruitment
    {
        [JsonPropertyName("files")]
        public int[] Files { get; set; }
    }
}
