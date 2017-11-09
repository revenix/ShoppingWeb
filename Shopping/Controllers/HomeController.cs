using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        UsuarioDA dao = new UsuarioDA();
        ProductoDA daoPRO = new ProductoDA();
        CategoriaDA daoCat = new CategoriaDA();


        public ActionResult Index()
        {
           // var foto = daoPRO.nombrefoto();


            return View(daoPRO.ListProductos().ToList());
            
        }

        public ActionResult convertImage(string id)
        {
             var foto = daoPRO.nombrefoto(id);
            return File (foto, "image/jpeg");

        }

        /* [HttpPost]
         public ActionResult Index(Usuario modelo)
         {
             return RedirectToAction("Contact");
         }*/

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

      
        [HttpPost]
        public ActionResult Login(Usuario user)
        {
            if (ModelState.IsValid)
            {
                if (dao.Login(user.Username, user.Contraseña))
                {
                 //   FormsAuthentication.SetAuthCookie(user.Username ,user. );
                    return RedirectToAction("About", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Products()
        {
            
            return View();
        }

        public ActionResult single()
        {
            return View(daoCat.ListCategoria().ToList());

        }
    }
}