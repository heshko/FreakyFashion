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
    public class ProductModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ProductModel(ApplicationDbContext context)
        {
            _context = context;
        }
      
        public Product product { get; set; }
        public string productType { get; set; }
        public List<Product> Products { get; set; }
        public void OnGet(int id)
        {
            product = _context.Products.SingleOrDefault(x => x.Id == id);
            productType = product.Type;
            if(productType== "trouser")
            {
                Products = _context.Products.Where(x => x.Type == "trouser").ToList();
            }else if(productType == "shirts")
            {
                Products = _context.Products.Where(x => x.Type == "shirts").ToList();
            }
            else
            {
                Products = _context.Products.Where(x => x.Type == "dress").ToList();
            }
        }
    }
}