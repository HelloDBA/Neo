using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace neo.Controllers
{
    public class weixinController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "";
        }
        public string token(string signature,string timestamp,string nonce,string echostr)
        {
            return echostr;
        }
    }
}
