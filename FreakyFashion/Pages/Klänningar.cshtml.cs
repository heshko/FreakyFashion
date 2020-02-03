using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion
{
    public class KlänningarModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }
        public KlänningarModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Product> Products { get; set; }
        public string type { get; set; }
        public void OnGet(string type)
        {
            Products = _context.Products.Where(x => x.Type == type).ToList();
            this.type = type;
        }
    }
}