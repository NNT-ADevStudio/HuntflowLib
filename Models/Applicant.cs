using HuntflowLib.Models.SubModels;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class Applicant
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }

        [JsonPropertyName("birthday")]
        public DateTime Birthday { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("skype")]
        public string Skype { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("money")]
        public string Money { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("photo")]
        public string Photo { get; set; }

        [JsonPropertyName("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("links")]
        public IEnumerable<Link> Links { get; set; }

    }
}
