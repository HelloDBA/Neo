using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace neo.Controllers
{
    public class AboutController : Controller
    {
        // GET: /<controller>/
        public string Index(string name, int id=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},ID:{id}");

        }
    }
}
