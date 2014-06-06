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
            
            System.Diagnostics.Trace.TraceInformation("We are in the About page");

            return View();
        } 

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Demo = "Demo2.";
            
            // Comment
            
            System.Diagnostics.Trace.TraceInformation("We are in the Contact page");
           
            return View();
        }
    }
}