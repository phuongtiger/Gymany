using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiService"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to make requests.</param>
        /// <param name="apiSettings">The API settings containing base URL and domain.</param>
        /// <param name="httpContextAccessor">The HTTP context accessor used to access session data.</param>
        public ApiService(HttpClient httpClient, ApiSettings apiSettings, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _apiSettings = apiSettings;
            _httpContextAccessor = httpContextAccessor;
        }
        /// <summary>
        /// Makes a GET request to the specified endpoint and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response should be deserialized.</typeparam>
        /// <param name="endpoint">The API endpoint to call.</param>
        /// <returns>A task representing the asynchronous operation, with a result of the specified type.</returns>
        public async Task<T> GetAsync<T>(string endpoint)
        {
            // Retrieve the token from the session.
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            // Set the Authorization header with the token.
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            // Construct the full URL using the base URL, domain, and endpoint.
            var response = await _httpClient.GetAsync($"{_apiSettings.BaseUrl}/{_apiSettings.ApiDomain}/{endpoint}");
            
            // Read the response content as a string.
            var responseData = await response.Content.ReadAsStringAsync();
            
            // Deserialize the response content to the specified type.
            return JsonSerializer.Deserialize<T>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}