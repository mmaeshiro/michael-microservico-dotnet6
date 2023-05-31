using Shopping.Web.Models;
using Shopping.Web.Services.IServices;
using Shopping.Web.Utils;

namespace Shopping.Web.Services
{
    public class ProductServices : IProductServices
    {     
        private readonly HttpClient _httpClient;
        public const string BasePath = "api/v1/Product";

        public ProductServices(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _httpClient.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _httpClient.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel productModel)
        {
            var response = await _httpClient.PostAsJson(BasePath, productModel);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else
                throw new Exception("Something went wrong when calling API");
        }            

        public async Task<ProductModel> UpdateProduct(ProductModel productModel)
        {
            var response = await _httpClient.PutAsJson(BasePath, productModel);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else
                throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _httpClient.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            throw new Exception("Something went wrong when calling API");
        }
    }
}
