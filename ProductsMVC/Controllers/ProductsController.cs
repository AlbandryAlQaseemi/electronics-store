using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsMVC.Models;

namespace ProductsMVC.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> IList = new List<Product>()
            {

                new Product {id =1, name="phone", price=4500, image= "https://www.jarir.com/cdn-cgi/image/fit=contain,width=200,height=400/https://www.jarir.com/media//catalog/product/5/5/556812.jpg?1"},
                new Product {id =2, name="laptop",price=6450, image= "https://www.jarir.com/cdn-cgi/image/fit=contain,width=200,height=400/https://www.jarir.com/media//catalog/product/5/5/553452.jpg?1"},
                new Product {id =3, name="mouse", price=200, image="https://www.jarir.com/cdn-cgi/image/fit=contain,width=200,height=400/https://www.jarir.com/media//catalog/product/4/5/450985.jpg?1"},
            };

     

        string[] colors = { "red", "black" };

        public ActionResult Index(string color="white")
        {


            ViewData["color"] = color;
            ViewData["IList"] = IList;
            return View();
        }
        public ActionResult white()
        {
            ViewData["IList"] = IList;
            return View();
        }
        public ActionResult Details(int? Id)
        {
            Product p = IList.Find(b => b.id == Id);

            if (p == null)
            {
                return Content("The product is not found");
            }
            else
            {

                ViewData["p"] = p;
                return View();
            }

        }


    }
}
