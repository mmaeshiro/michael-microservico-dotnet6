using Shopping.Web.Models;

namespace Shopping.Web.Services.IServices
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel productModel);
        Task<ProductModel> UpdateProduct(ProductModel productModel);
        Task<bool> DeleteProductById(long id);
    }
}
