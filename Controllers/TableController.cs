using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SbAdmin.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Tables()
        {
            return View();
        }
    }
}
