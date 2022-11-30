using Microsoft.AspNetCore.Razor.TagHelpers;
using StarWarsInfo.Models;
using starWarsInfo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Reflection.Metadata;

namespace StarWarsInfo.TagHelpers
{

    public class FilmInfo : TagHelper
    {
        Film _film = null;
        private readonly IHttpClientFactory _httpClientFactory;
        public List<string> myElements { get; set; } = new List<string>();

        public FilmInfo(IHttpClientFactory httpClientFactory)
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
                    _film = await httpResponse.Content.ReadFromJsonAsync<Film>();
                    content = $"{content}<h4>{_film.Title}</h4>" +
                    $"<li>{_film.Episode_id}</li>" +
                    $"<li>{_film.Opening_crawl}</li>" +
                    $"<li>{_film.Director}</li>" +
                    $"<li>{_film.Producer}</li>" +
                    $"<li>{_film.Release_date}</li>" +
                    $"<li>{_film.Url}</li>" +
                    $"<li>{_film.Created}</li>" +
                    $"<li>{_film.Edited}</li>";
                }

            }
            output.Content.SetHtmlContent(content);
        }


    }
}