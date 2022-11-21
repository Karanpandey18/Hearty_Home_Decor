using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using HeartyHomeDecor.Repositories;
using HeartyHomeDecor.Models;
using HeartyHomeDecor.Data;
using AutoMapper;

namespace HeartyHomeDecor.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public List<ProductViewModel> GetProductsList(string search = "")
        {
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            try
            {
                productViewModels = _context.Product.Include(x => x.Category).Where(x => string.IsNullOrEmpty(search) || x.ProductName.ToLower().Contains(search.ToLower()))
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    CategoryName = x.Category.Name,
                    ProductDetail = x.ProductDetail,
                    SKU = x.SKU,
                    Price = x.Price,
                    Rating = x.Rating

                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return productViewModels;
        }

        public List<Category> GetCategories()
        {
            List<Category> lstCategory = new List<Category>();
            try
            {
                lstCategory = _context.Category.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lstCategory;
        }

        public int AddUpdateProduct(ProductViewModel productViewModel)
        {
            int result = 0;
            //SqlConnection con = null;

            try
            {
                Product product = _mapper.Map<Product>(productViewModel);
                if(product.Id > 0)
                {
                    _context.Product.Update(product);
                }
                else
                {
                    _context.Product.Add(product);
                }
                result = _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }

        public ProductViewModel GetProductDetailById(int id)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == id);
            ProductViewModel productViewModel = _mapper.Map<ProductViewModel>(product);
            return productViewModel;
        }

        public int DeleteProductById(int id)
        {
            int result = 0;
            try
            {
                var data = _context.Product.Find(id);
                if (data != null)
                {
                    _context.Product.Remove(data);
                    result = _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}



