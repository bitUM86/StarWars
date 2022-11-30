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
using Microsoft.AspNetCore.Http;

namespace StarWarsInfo.TagHelpers
{

    public class FilmInfo : TagHelper
    {
        
        private readonly IHttpClientFactory _httpClientFactory;
        public List<string> myElements { get; set; } = new List<string>();
        List<Film> films = new List<Film>();
        List<Task> tasks = new List<Task>();
        public FilmInfo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            Film _film = null;
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
                        _film = await httpResponse.Content.ReadFromJsonAsync<Film>();
                        films.Add(_film);
                    }

                }));
            }
                await Task.WhenAll(tasks);

                foreach (var film in films)
                {
                    content = $"{content}<h4>{film.Title}</h4>" +
                    $"<li>{film.Episode_id}</li>" +
                    $"<li>{film.Opening_crawl}</li>" +
                    $"<li>{film.Director}</li>" +
                    $"<li>{film.Producer}</li>" +
                    $"<li>{film.Release_date}</li>" +
                    $"<li>{film.Url}</li>" +
                    $"<li>{film.Created}</li>" +
                    $"<li>{film.Edited}</li>";
                }

                output.Content.SetHtmlContent(content);
        }
    }
}
