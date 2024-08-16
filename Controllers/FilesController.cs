using HuntflowLib.Models;
using HuntflowLib.Models.HelpModels;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
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

        public async Task<UploadFile> UploadFile(string fileName ,string fileNameStar, string path)
        {
            try
            {
                using (var client = Auth.GenerateHttpClient())
                {

                    client.DefaultRequestHeaders.Add("x-file-parse", "true");
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    var content = new MultipartFormDataContent();

                    var fileContent = new StreamContent(File.OpenRead(path));
                    //fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(MediaTypeNames.Application.Pdf);
                    //content.Add(fileContent, "file", fileName);


                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(MediaTypeNames.Application.Pdf);
                    fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                    {
                        FileName = fileName,
                        FileNameStar = fileNameStar,
                        Name = "file"
                    };

                    fileContent.Headers.ContentDisposition.Parameters.Clear();
                    fileContent.Headers.ContentDisposition.Parameters.Add(new NameValueHeaderValue("filename", $"{fileName}"));
                    fileContent.Headers.ContentDisposition.Parameters.Add(new NameValueHeaderValue("filename*", $"\"{fileNameStar}\""));
                    fileContent.Headers.ContentDisposition.Parameters.Add(new NameValueHeaderValue("name", "file"));
                    content.Add(fileContent, "file", fileName);

                    var response = await client.PostAsync($"{ControllerUrl}", content);
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<UploadFile>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
