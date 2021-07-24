using CrudOperation.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace CrudOperation.Controllers
{
    public class ProductsController : Controller
    {
        //GET: AllProducts
        db_NimapTestEntities dbObj = new db_NimapTestEntities();
        public ActionResult AllProducts(tbl_NimapTest obj)
        {
            if (obj != null)
                return View(obj);
            else
            return View();
        }

        [HttpPost]
        public ActionResult AddProducts(tbl_NimapTest model)
        {

            tbl_NimapTest obj = new tbl_NimapTest
            {
                ProductId = model.ProductId,
                ProductName = model.ProductName,
                CategoryId = model.CategoryId,
                CategoryName = model.CategoryName
            };

            dbObj.tbl_NimapTest.Add(obj);
            dbObj.SaveChanges();
            ViewBag.Message = "Data Inserted Successfully Click";

            return View("AllProducts");
        }



        public ActionResult ProductsList(int? i)
        {
            var res = dbObj.tbl_NimapTest.ToList().ToPagedList(i ?? 1, 10);
            return View(res);
        }

        public ActionResult DeleteProducts(int id)
        {
            var res = dbObj.tbl_NimapTest.Where(x => x.ProductId == id).First();
            dbObj.tbl_NimapTest.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tbl_NimapTest.ToList();

            return View("ProductsList", list);
        }







    }

}