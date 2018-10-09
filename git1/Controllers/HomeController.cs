using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace git1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // get list from session in any, else create new empthy one
        [HttpPost]
        public ActionResult Save(string Jitem)
        {
            var item = new object();
            if (Jitem!=null)
                item = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(Jitem);
            else
                return Json("empthy search", JsonRequestBehavior.AllowGet);

            var list = (Session["gitHub"] as List<object>) ?? new List<object>();
            list.Add(item);
            //save the new item at session
            Session["gitHub"] = list;
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        //read the current list from session      
        [HttpGet]
        public ActionResult List()
        {

            var list = (Session["gitHub"] as List<object>) ?? new List<object>();
            return Json(list, JsonRequestBehavior.AllowGet);

        }

    

    }
}