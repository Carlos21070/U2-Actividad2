using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using U2_Actividad2.Models;

namespace U2_Practica3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var compositores = context.Villancico.OrderByDescending(x => x.Anyo);
            return View(compositores);
        }
        public IActionResult Villancico(int? id)
        {
            
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            villancicosContext context = new villancicosContext();
            var compositores = context.Villancico.FirstOrDefault(x => x.Id==id);
            if (compositores==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
              return View(compositores);
            }
            
        }
    }
}
