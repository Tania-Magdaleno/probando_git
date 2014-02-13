using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk2_RSVPwapp.Models;

namespace Pk2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Buenos Dias!!!" : "Buena Tarde!!!";

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        { 
            //Todo: Enviar respuesta al correo ddel organizador
            return View("Agradecimientos", guestResponse);
        }

    }
}
