using HeartyHomeDecor.Controllers;
using HeartyHomeDecor.Models;
using HeartyHomeDecor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductViewModel> GetProductsList(string search = "")
        {
            return _productRepository.GetProductsList(search);
        }

        public List<Category> GetCategories()
        {
            return _productRepository.GetCategories();
        }

        public int AddUpdateProduct(ProductViewModel productViewModel)
        {
            return _productRepository.AddUpdateProduct(productViewModel);
        }

        public ProductViewModel GetProductDetailById(int id)
        {
            return _productRepository.GetProductDetailById(id);
        }

        public int DeleteProductById(int id)
        {
            return _productRepository.DeleteProductById(id);
        }
    }
}
