using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using petclinicdemo.Models.DTO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace petclinicdemo.Controllers
{
    public class SpotifyController : Controller
    {
        private readonly ILogger<SpotifyController> _logger;
        private const string URL_API_SPOTIFY = "https://api.spotify.com/v1/";
        private const string ACCESS_TOKEN = "BQDIM1CUst4K2ei-OvVC3P8BNvAJnv4NIEh_useZxr8qpeN9f1BIWRQhWSykvqXtJZM4S6gGhnt4pz1_o3XBV574Ni5QXkYVZOieufzUDx1RoBfh-QKFsZFXvdsha0BlA2PjI76grecejEKBwqG823SNBw";

        public SpotifyController(ILogger<SpotifyController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.BaseAddress = new Uri(URL_API_SPOTIFY);
            httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Bearer", ACCESS_TOKEN);
            var streamTask = httpClient.GetStreamAsync( "users/12153957956");
            var me = await JsonSerializer.DeserializeAsync<UserSpotify>(await streamTask);
            
            return View(me);

        }


    }
}