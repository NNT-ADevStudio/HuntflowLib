using HuntflowLib.Models.SubModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class Applicant
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null;

        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = null;

        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; } = null;

        [JsonPropertyName("email")]
        public string Email { get; set; } = null;

        [JsonPropertyName("links")]
        public IEnumerable<Link> Links { get; set; } = null;
    }
}
