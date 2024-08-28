using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class MovieController:Controller
    {
       public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content= $"Movie with Id {id}";
            //result.ContentType = "object/pdf";
            //return result;
            return Content($"Movie with Id {id}","txt/html");
        }
        [ActionName("Hamada")]
        [HttpGet]
        public IActionResult Index()
        {
            //RedirectResult redirect = new RedirectResult("https://www.amazon.com/");
            //return redirect;
            return Redirect("https://www.amazon.com/");

        }

    }
}
