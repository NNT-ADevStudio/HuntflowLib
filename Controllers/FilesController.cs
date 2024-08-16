using HuntflowLib.Models;
using HuntflowLib.Models.HelpModels;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace HuntflowLib.Controllers
{
    public class FilesController : MainController
    {
        public FilesController(Auth auth) : base(auth)
        {
        }

        public override string ControllerUrl => "upload";

        public async Task<UploadFile> UploadFile(string preset, byte[] fileBytes)
        {
            try
            {
                using (var client = Auth.HttpClient)
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));

                    HttpContent content = new MultipartFormDataContent() 
                    { 
                        { new ByteArrayContent(fileBytes), "file" }, 
                        { new StringContent(preset), "preset" } 
                    };

                    var response = await client.PostAsync($"{ControllerUrl}", content);
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<UploadFile>(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
