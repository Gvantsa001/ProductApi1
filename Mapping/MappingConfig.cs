using Mapster;
using ProductApi.Models;
using ProductAPI.DTOs;
using ProductApi.Models;

namespace ProductAPI.Mappings
{
    public static class MappingConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<Product, ProductDTO>.NewConfig();
        }
    }
}