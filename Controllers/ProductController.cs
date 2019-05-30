using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiftAndShiftApp.Models.Models;
using LiftAndShiftMvcApp.Web.ProductServiceReference;

namespace LiftAndShiftMvcApp.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductManagementClient clientProduct = new ProductManagementClient();

        // GET: Product
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductModel productModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(productModel.ImageFile.FileName);
            string extn = Path.GetExtension(productModel.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extn;
            string url = ConfigurationManager.AppSettings["path"];
            productModel.ImagePath = url + fileName;
            fileName = Path.Combine(Server.MapPath(url), fileName);
            productModel.ImageFile.SaveAs(fileName);


            clientProduct.AddProduct(productModel);


            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult ViewList()
        {
            var products = clientProduct.GetAllProducts();
            return View(products);
        }



    }
}