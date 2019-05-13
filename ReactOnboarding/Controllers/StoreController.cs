using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReactOnboarding.Models;
using Newtonsoft.Json;

namespace ReactOnboarding.Controllers
{
    public class StoreController : Controller
    {
        DemoProject db = new DemoProject();

        public ActionResult Index()
        {
            return View();
        }

        // GET Products
        public JsonResult GetStoreList()
        {
            try
            {
                var storeList = db.Stores.Select(x => new StoreModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                }).ToList();

                return Json(storeList, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.Write(e.Data + "Exception Occured");
                return new JsonResult { Data = "Data Not Found", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        // CREATE Store
       
            try
            {
                db.Stores.Add(store);
                db.SaveChanges();
            }
           
            {
                Console.Write(e.Data + "Exception Occured");
                return new JsonResult { Data = "Store Create Failed", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            return new JsonResult { Data = "Success", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // DELETE Product
        public JsonResult DeleteStore(int id)
        {
            try
            
               
                {
                    db.Stores.Remove(store);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Data + "Exception Occured");
                return new JsonResult { Data = "Deletion Failed", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            return new JsonResult { Data = "Success", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // UPDATE Product
        public JsonResult GetUpdateStore(int id)
        {
            try
            {
                Store store = db.Stores.Where(x => x.Id == id).SingleOrDefault();
                
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                return Json(value, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
               
                return new JsonResult { Data = "Not Found", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        public JsonResult UpdateStore(Store store)
        {
            try
            {
                Store sto = db.Stores.Where(p => p.Id == store.Id).SingleOrDefault();
                sto.Name = store.Name;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.Write(e.Data + "Exception Occured");
                return new JsonResult { Data = "Store Update Failed", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            return new JsonResult { Data = "Success", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
