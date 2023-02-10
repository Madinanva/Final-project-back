using ClarieTheme.DAL;
using ClarieTheme.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarieTheme.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Products = await _context.Products.Where(p => p.IsDeleted).ToListAsync();
            homeVM.Sliders = await _context.Sliders.Where(s => s.IsDeleted).ToListAsync();
            return View(homeVM);
        }
    }
}
