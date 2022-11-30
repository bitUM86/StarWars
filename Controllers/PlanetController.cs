using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Net.Http.Headers;
using StarWarsInfo.Models;
using starWarsInfo.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;


namespace starWarsInfo.Controllers
{
    public class PlanetController : Controller
    {
       
        private readonly IHttpClientFactory _httpClientFactory;
       
        public PlanetController(IHttpClientFactory httpClientFactory)
        {
           _httpClientFactory = httpClientFactory;
        }

        public async Task<ViewResult> GetPlanet(int id )
        {
            Planet planet   = null;
            var httpRequest  = new HttpRequestMessage(HttpMethod.Get, $"http://swapi.dev/api/planets/{id}/");
            var httpClient   = _httpClientFactory.CreateClient();
            var httpResponse = await httpClient.SendAsync(httpRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                planet = await httpResponse.Content.ReadFromJsonAsync<Planet>();
            }
            return View("Index", planet);
        }
        
       
    }
}
