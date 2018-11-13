using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<container>"+ 
                "<form method='post'>"+
                "<input type = 'text' name = 'name'/>"+
                "<select size = '1' multiple name = 'language' autofocus>"+
                "<option value = 'LV'>Latvia</option>"+
                "<option value = 'FR'>French</option>"+
                "<option value = 'EN' selected>English</option>" +
                "<option value = 'SP'>Spanish</option>" +
                "<option value = 'GE'>German</option>" +
                "</select>" +
                "<input type = 'submit' value = 'Greet me!'/>"+
                "</form>"+
                "</container>";          
            return Content(html,"text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult CreateMessage(string name, string language)
        {
            Dictionary<string, string> greetings = new Dictionary<string, string>(5);
            greetings.Add("LV", "Sveiki");
            greetings.Add("EN", "Hello");
            greetings.Add("FR", "Bonjour");
            greetings.Add("SP", "Hola");
            greetings.Add("GE", "Hallo");

            return Content(string.Format("<h1>{0}, {1}!</h1>", greetings[language], name), "text/html");
        }


    }
}
