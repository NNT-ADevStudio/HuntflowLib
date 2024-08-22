using HuntflowLib.Models;
using HuntflowLib.Models.HelpModels;
using System.Net.Http;
using System.Text.Json;
using System;
using System.Threading.Tasks;

namespace HuntflowLib.Controllers
{
    public class ApplicantOnVacancyController : MainController
    {
        public ApplicantOnVacancyController(Auth auth) : base(auth) { }

        public override string ControllerUrl => "applicants";

        public async Task<bool> ChangeRecruitment(int id, RecruitmentVacancy recruitment)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    HttpContent content = new StringContent(JsonSerializer.Serialize(recruitment), null, "application/json");

                    var response = await client.PutAsync($"{ControllerUrl}/{id}/vacancy", content);

                    if (response.IsSuccessStatusCode)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
