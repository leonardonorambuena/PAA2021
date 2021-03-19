using Ejecicio1.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Ejecicio1.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> Products;
        public ProductsController()
        {
            Products = new List<Product>();
            Products.Add(new Product {
                Id = 1,
                Name = "Zelda",
                Image = "https://i.pinimg.com/originals/0f/63/61/0f6361a920f327e30b5de2e03514ede8.jpg",
                Price = 25000,
                Stock = 2
            });


            Products.Add(new Product
            {
                Id = 2,
                Name = "Mario Bros",
                Image = "https://www.mariowiki.com/images/a/a7/MarioBoss365.jpeg",
                Price = 27000,
                Stock = 4
            });

        }
        // GET: Products
        public ActionResult Index()
        {
            return View(Products);
        }
        // HttpGet esto no lo ve el usuario
        public ActionResult Show(int? id)
        {
            if (id == null) return RedirectToAction("NotFound", "Inicio");

            Product product = Products.FirstOrDefault(x => x.Id == (int)id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "El producto no fue encontrado";
                return RedirectToAction("NotFound", "Inicio");
            }
                


            return View(product);
        }
    }
}