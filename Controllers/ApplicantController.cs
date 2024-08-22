using System.Text.Json;
using System.Threading.Tasks;
using System;
using HuntflowLib.Models;
using HuntflowLib.Models.HelpModels;
using System.Net.Http;

namespace HuntflowLib.Controllers
{
    public class ApplicantController : MainController
    {
        public override string ControllerUrl => "applicants";

        public ApplicantController(Auth auth) : base(auth)
        {
        }

        public async Task<ListModel<Applicant>> Get(int page = 1)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    var response = await client.GetAsync($"{ControllerUrl}?page={page}");
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<ListModel<Applicant>>(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ListModel<Applicant>> Search(string searchQuery)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    var response = await client.GetAsync($"{ControllerUrl}/search?q={searchQuery}");
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<ListModel<Applicant>>(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Applicant> GetById(int id)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    var response = await client.GetAsync($"{ControllerUrl}/{id}");
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Applicant>(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CreateLog(int id, Recruitment recruitment) 
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {
                    HttpContent content = new StringContent(JsonSerializer.Serialize(recruitment), null, "application/json");

                    var response = await client.PostAsync($"{ControllerUrl}/{id}/logs", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
