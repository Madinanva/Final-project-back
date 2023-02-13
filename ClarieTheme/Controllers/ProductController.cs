using ClarieTheme.DAL;
using ClarieTheme.Models;
using ClarieTheme.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarieTheme.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> model = _context.Products.Where(a => !a.IsDeleted).ToList();
            return View(model);
        }
        public IActionResult Search(string search)
        {
            List<Product> products = _context.Products.Where(p => !p.IsDeleted && p.Title.ToLower().Contains(search.ToLower())).ToList();
            return PartialView("_SearchPartial", products);
        }
        public IActionResult Detail(int id)
        {
            Product product = _context.Products
                .Where(p => !p.IsDeleted && p.Id == id).FirstOrDefault();
            ProductDetailVM productDetailVM = new ProductDetailVM()
            {
                Product = product
            };
            return View(product);
        }
    }
}
