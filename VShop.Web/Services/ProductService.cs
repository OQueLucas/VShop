﻿using System.Text.Json;
using VShop.Web.Models;
using VShop.Web.Services.Contracts;

namespace VShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private const string apiEndpoint = "api/products/";
        private readonly JsonSerializerOptions _options;
        private ProductViewModel productVM;
        private IEnumerable<ProductViewModel> productsVM;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> FindProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> CreateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> UpdateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
