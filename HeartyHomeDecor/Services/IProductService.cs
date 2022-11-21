using HeartyHomeDecor.Models;
using System.Collections.Generic;

namespace HeartyHomeDecor.Controllers
{
    public interface IProductService
    {
        List<ProductViewModel> GetProductsList(string search = "");
        List<Category> GetCategories();
        int AddUpdateProduct(ProductViewModel productViewModel);
        ProductViewModel GetProductDetailById(int id);
        int DeleteProductById(int id);
    }
}