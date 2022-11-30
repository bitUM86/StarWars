using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StarWarsInfo.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsInfo.TagHelpers
{
    public class ResidentInfo : TagHelper
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public List<string> myElements { get; set; } = new List<string>();
        List<Resident> residents = new List<Resident>();
        List<Task> tasks = new List<Task>();
        public ResidentInfo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            Resident _resident = null;
            var client = _httpClientFactory.CreateClient();
            output.TagName = "div";
            string content = "";
            foreach (string item in myElements)
            {
                tasks.Add(Task.Run(async () =>
                {
                    var httpRequest = new HttpRequestMessage(HttpMethod.Get, item);
                    var httpResponse = await client.SendAsync(httpRequest);
                   
                    if (httpResponse.IsSuccessStatusCode)
                    {
                       _resident = await httpResponse.Content.ReadFromJsonAsync<Resident>();
                        residents.Add(_resident);
                    }

                }));
            }
           await Task.WhenAll(tasks);
            
            foreach (var res in residents)
            {
                content = $"{content}<h4>{res.Name}</h4>" +
                    $"<li>{res.Birth_year}</li>" +
                    $"<li>{res.Eye_color}</li>" +
                    $"<li>{res.Gender}</li>" +
                    $"<li>{res.Hair_color}</li>" +
                    $"<li>{res.Height}</li>" +
                    $"<li>{res.Mass}</li>" +
                    $"<li>{res.Skin_color}</li>" +
                    $"<li>{res.Homeworld}</li>" +
                    $"<li>{res.Url}</li>" +
                    $"<li>{res.Created}</li>" +
                    $"<li>{res.Edited}</li>";
            }
            output.Content.SetHtmlContent(content);
            }
        }
}
   
               