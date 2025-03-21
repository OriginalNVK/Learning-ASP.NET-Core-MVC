using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.UI.Models;
using NZWalks.UI.Models.DTO;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace NZWalks.UI.Controllers
{
	public class RegionsController : Controller
	{
		private readonly IHttpClientFactory httpClientFactory;

		public RegionsController(IHttpClientFactory httpClientFactory)
        {
			this.httpClientFactory = httpClientFactory;
		}
        public async Task<IActionResult> Index()
		{
			List<RegionDto> response = new List<RegionDto>();
			try
			{
				var HttpClient = httpClientFactory.CreateClient();
				var httpResponse = await HttpClient.GetAsync("https://localhost:7263/api/regions");

				httpResponse.EnsureSuccessStatusCode();
				response.AddRange(await httpResponse.Content.ReadFromJsonAsync<IEnumerable<RegionDto>>());

				ViewBag.Response = response;
			}
			catch(Exception ex)
			{
				// log exception
			}
			return View(response);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddRegionViewModel addRegionViewModel)
		{
			var client = httpClientFactory.CreateClient();

			var httpRequestMessage = new HttpRequestMessage()
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri("https://localhost:7263/api/regions"),
				Content = new StringContent(JsonSerializer.Serialize(addRegionViewModel), Encoding.UTF8, "application/json")
			};

			var httpResponseMessage = await client.SendAsync(httpRequestMessage);
			httpResponseMessage.EnsureSuccessStatusCode();

			var response = await httpResponseMessage.Content.ReadFromJsonAsync<RegionDto>();

			if (response is not null)
			{
				return RedirectToAction("Index", "Regions");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult>Edit(Guid id)
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetFromJsonAsync<RegionDto>($"https://localhost:7263/api/regions/{id.ToString()}");
			
			if(response is not null)
			{
				return View(response);
			}
			return View(null);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(RegionDto update)
		{
			var client = httpClientFactory.CreateClient();

			var httpRequestMessage = new HttpRequestMessage() {
				Method = HttpMethod.Put,
				RequestUri = new Uri($"https://localhost:7263/api/regions/{update.Id}"),
				Content = new StringContent(JsonSerializer.Serialize(update), Encoding.UTF8, "application/json")
			};

			var httpResponse = await client.SendAsync(httpRequestMessage);

			httpResponse.EnsureSuccessStatusCode();

			var response = await httpResponse.Content.ReadFromJsonAsync<RegionDto>();

			if (response is not null)
			{
				return RedirectToAction("Edit", "Regions");
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Delete(Guid id)
		{
			try
			{
				var client = httpClientFactory.CreateClient();

				var httpResponse = await client.DeleteAsync($"https://localhost:7263/api/regions/{id}");

				httpResponse.EnsureSuccessStatusCode();
				return RedirectToAction("Index", "Regions");
			}
			catch (Exception ex)
			{
				// log exception
			}
			return View();
			
		}
	}
}
