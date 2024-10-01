using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Core.Common;

/// <summary>
/// Represents the service for API configuration.
/// </summary>
namespace Gymany.Core.Service
{
    /// <summary>
    /// Service class for making API calls.
    /// </summary>
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiSettings _apiSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiService"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to make requests.</param>
        /// <param name="apiSettings">The API settings containing base URL and domain.</param>
        public ApiService(HttpClient httpClient, ApiSettings apiSettings)
        {
            _httpClient = httpClient;
            _apiSettings = apiSettings;
        }

        /// <summary>
        /// Makes a GET request to the specified endpoint and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response should be deserialized.</typeparam>
        /// <param name="endpoint">The API endpoint to call.</param>
        /// <returns>A task representing the asynchronous operation, with a result of the specified type.</returns>
        public async Task<T> GetAsync<T>(string endpoint)
        {
            // Construct the full URL using the base URL, domain, and endpoint.
            var response = await _httpClient.GetAsync($"{_apiSettings.BaseUrl}/{_apiSettings.ApiDomain}/{endpoint}");
            
            // Read the response content as a string.
            var responseData = await response.Content.ReadAsStringAsync();
            
            // Deserialize the response content to the specified type.
            return JsonSerializer.Deserialize<T>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}