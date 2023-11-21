using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SoftwareShopping.Web.Views.Product
{
    public class EditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    } }