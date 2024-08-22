using System.Text.Json.Serialization;

namespace HuntflowLib.Models
{
    public class RecruitmentVacancy : Recruitment
    {
        [JsonPropertyName("vacancy")]
        public int Vacancy { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
