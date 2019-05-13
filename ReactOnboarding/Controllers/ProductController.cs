using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReactOnboarding.Models;
using Newtonsoft.Json;

namespace ReactOnboarding.Controllers
{
    public class ProductController : Controller
    {
       DemoProject db = new DemoProject();

        public ActionResult Index()
        {
            return View();
        }

       
