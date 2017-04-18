using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextR.Models;
using TextR.ViewModel;

namespace TextR.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View("PedirDatos");
            /*
            var gestor = new GestorVentas();
            var ListaProductos = gestor.ObtenerProductos();

            var ventas = new GestorVentas();
            
            Clientes cliente = new Clientes { Nombre = "martin", Apellido = "martinnn" };
            return View(cliente);
            */
        }
      

    }
    
}