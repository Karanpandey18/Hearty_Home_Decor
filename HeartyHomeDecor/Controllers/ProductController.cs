using HeartyHomeDecor.Models;
using HeartyHomeDecor.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        //Bind Product List
        public IActionResult ProductDetail(string sortField, string currentSortField, string currentSortOrder, string searchString, int pageIndex = 1)
        {
            var productDetails = _productService.GetProductsList(searchString);
            ViewBag.CurrentFilter = searchString;
            ViewData["CurrentSort"] = sortField;
            int pageSize = 5;
            if (productDetails != null && productDetails.Count > 0)
            {
                productDetails = SortProductData(productDetails, sortField, currentSortField, currentSortOrder);
            }
            productDetails = PagingList<ProductViewModel>.CreateAsync(productDetails.AsQueryable<ProductViewModel>(), pageIndex, pageSize);
            return View("ProductList",productDetails);
        }

        //Bind Categories in Add Product form
        [HttpGet]
        public IActionResult AddProduct()
        {
            BindViewData();
            return View();
        }

        //Set Data while open Edit Product Form
        [HttpGet]
        public IActionResult UpdateProduct(int Id)
        {
            var productDetail = _productService.GetProductDetailById(Id);
            BindViewData();
            return View("AddProduct", productDetail);
        }

        // Insert/ Update Product
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.AddUpdateProduct(model);
                return RedirectToAction("ProductDetail");
            }
            BindViewData();
            return View();
        }

        //Delete Product
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProductById(id);
            return RedirectToAction("ProductDetail");
        }

        #region Private methods

        //Get all the Categories
        private void BindViewData()
        {
            var categories = _productService.GetCategories();
            var categoryList = categories.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id + ""
            }).ToList();
            categoryList.Insert(0, new SelectListItem { Text = "Select Category", Value = "0" });
            ViewData["Categories"] = categoryList;

        }

        //Sorting of Product Data
        private List<ProductViewModel> SortProductData(List<ProductViewModel> products, string sortField, string currentSortField, string currentSortOrder)
        {
            if (string.IsNullOrEmpty(sortField))
            {
                ViewBag.SortField = "Id";
                ViewBag.SortOrder = "Desc";
            }
            else
            {
                if (currentSortField == sortField)
                {
                    ViewBag.SortOrder = currentSortOrder == "Asc" ? "Desc" : "Asc";
                }
                else
                {
                    ViewBag.SortOrder = "Asc";
                }
                ViewBag.SortField = sortField;
            }

            var propertyInfo = typeof(ProductViewModel).GetProperty(ViewBag.SortField);
            if (ViewBag.SortOrder == "Asc")
            {
                products = products.OrderBy(s => propertyInfo.GetValue(s, null)).ToList();
            }
            else
            {
                products = products.OrderByDescending(s => propertyInfo.GetValue(s, null)).ToList();
            }
            return products;
        }

        #endregion
    }
}
