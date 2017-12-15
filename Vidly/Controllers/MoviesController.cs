using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Jarod"};
            return View(movie);
        }

        //Return specified ActionResult - ContentResult - Content() is help method
        public ActionResult Content()
        {
            return Content("This is a view show ContentResult");
        }

        //Return specified ActionResult - HttpNotFoundResult( 404 page) - HttpNotFound() is help method
        public ActionResult HttpNotFound()
        {
            return HttpNotFound();
        }

        //Return JSON view
        public ActionResult ReturnJSON()
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            result.Data = new Movie(){Id=1, Name = "Jarod"}; //Could be single object, list, etc.
            string json = "{\"Id\":1,\"Name\":\"刘备\",\"Age\":\"22\"}";
            result.Data = json;
            return result;

        }

        public ActionResult ReturnEmpty()
        {
            return new EmptyResult();
        }
    }
}