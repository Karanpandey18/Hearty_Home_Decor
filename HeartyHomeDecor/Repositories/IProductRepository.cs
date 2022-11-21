using HeartyHomeDecor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Repositories
{
    public interface IProductRepository
    {
        List<ProductViewModel> GetProductsList(string search = "");

        List<Category> GetCategories();
        int AddUpdateProduct(ProductViewModel productViewModel);

        ProductViewModel GetProductDetailById(int id);

        int DeleteProductById(int id);
    }
}
