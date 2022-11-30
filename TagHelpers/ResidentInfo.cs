using Microsoft.AspNetCore.Razor.TagHelpers;
using StarWarsInfo.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsInfo.TagHelpers
{
    public class ResidentInfo : TagHelper
    {
        Resident _resident = null;
        private readonly IHttpClientFactory _httpClientFactory;
        public List<string> myElements { get; set; } = new List<string>();

        public ResidentInfo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var httpClient = _httpClientFactory.CreateClient();
            output.TagName = "div";
            string content = "";
            foreach (string item in myElements)
            {
                var httpRequest = new HttpRequestMessage(HttpMethod.Get, item);
                var httpResponse = await httpClient.SendAsync(httpRequest);
                if (httpResponse.IsSuccessStatusCode)
                {
                    _resident = await httpResponse.Content.ReadFromJsonAsync<Resident>();
                    content = $"{content}<h4>{_resident.Name}</h4>" +
                    $"<li>{_resident.Birth_year}</li>" +
                    $"<li>{_resident.Eye_color}</li>" +
                    $"<li>{_resident.Gender}</li>" +
                    $"<li>{_resident.Hair_color}</li>" +
                    $"<li>{_resident.Height}</li>" +
                    $"<li>{_resident.Mass}</li>" +
                    $"<li>{_resident.Skin_color}</li>" +
                    $"<li>{_resident.Homeworld}</li>" +
                    $"<li>{_resident.Url}</li>" +
                    $"<li>{_resident.Created}</li>" +
                    $"<li>{_resident.Edited}</li>";
                }

            }
            output.Content.SetHtmlContent(content);
        }


    }
}