using System.Web.Mvc;

namespace GitWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
            ViewBag.Demo = "Demo1.";
            
            // Comment
            
            System.Diagnostics.Trace.TraceInformation("We are in the Contact page - Yippee");
           
            return View();
        }
    }
}