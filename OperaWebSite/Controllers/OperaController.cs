using Microsoft.AspNetCore.Mvc;
using OperaWebSite.Data;
using OperaWebSite.Models;
using System.Linq;

namespace OperaWebSite.Controllers
{
    public class OperaController : Controller
    {
        private readonly DBOperaDemoContext context;

        public OperaController(DBOperaDemoContext context)
        {
            this.context = context;
        }

        //GET /Opera
        //GET /Opera/index
        [HttpGet]
        public IActionResult Index()
        {
            //lista de operas
            var operas = context.Operas.ToList();

            //Envia las operas a la vista
            return View(operas);
        }

        //Get opera/create
        [HttpGet]
        public ActionResult Create()
        {
            Opera opera = new Opera();
            return View("Create", opera);//Devuelve el hmlt(View) al cliente
        }

        //Post opera/create
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        //Get opera/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var opera = context.Operas.Find(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", opera);//Devuelve el hmlt(View) al cliente
            }
        }

        //Post opera/delete/1
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                context.Operas.Remove(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //Get opera/Details/4
        [HttpGet]
        public ActionResult Details(int id)
        {
            var opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
               
                return View("Detalle", opera);
            }
        }

        private Opera TraerUna(int id)
        {
            return context.Operas.Find(id);
        }
    }
}
