using ASPNET6WebApiDemo.Wrappers;
using WebAPI.Consumer.Models;

namespace WebAPI.Consumer.Services
{
    public class CustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PagedResponse<List<Customer>>> GetCustomersAsync(int pageNumber, int pageSize)
        {
            var apiEndpoint = $"/api/customer?pageNumber={pageNumber}&pageSize={pageSize}";
            return await _httpClient.GetFromJsonAsync<PagedResponse<List<Customer>>>(apiEndpoint);
        }
    }
}
