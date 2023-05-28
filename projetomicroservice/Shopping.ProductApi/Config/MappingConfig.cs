using AutoMapper;
using Shopping.ProductApi.Data.ValueObjects;
using Shopping.ProductApi.Model;

namespace Shopping.ProductApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductVO, Product>();
                c.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
