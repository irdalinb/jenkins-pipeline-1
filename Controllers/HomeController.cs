using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiftAndShiftMvcApp.Web.OrderServiceReference;
using LiftAndShiftMvcApp.Web.ProductServiceReference;

namespace LiftAndShiftMvcApp.Web.Controllers
{    
    public class HomeController : Controller
    {
        OrdersManagementClient client = new OrdersManagementClient();
        ProductManagementClient clientProduct = new ProductManagementClient();

        public ActionResult Index()
        {
            //List<ProductModel> productModels = new List<ProductModel>();
            //productModels.Add(new ProductModel { Description = "test1", ImagePath = "testpath1", Name = "test1", Price = 55, Quantity = 5 });

            //LiftAndShiftApp.Models.Models.ProductModel productModel = new LiftAndShiftApp.Models.Models.ProductModel { Description = "test1", ImagePath = "testpath1", Name = "test1", Price = 55, Quantity = 5 };

            //clientProduct.AddProduct(productModel);
            //if()
            //ViewBag.Message = client.CreateOrder(productModels.ToArray());
            return View();
        }

        public ActionResult Order()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}