using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMiProyecto.Models;
using WebMiProyecto.ExtensionClasses;
using WebMiProyecto.Common;

namespace WebMiProyecto.Controllers
{
    public class ClientesController : Controller
    {
        GestorClientes gestorClientes = new GestorClientes();
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alta()
        {
            return View();
        }
        public ActionResult Guardar(ViewModel.ClienteViewModel clienteViewModel)
        {
            if(ModelState.IsValid)
            {
                gestorClientes.Guardar(clienteViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            var cliente = gestorClientes.Listar();
            return View(cliente.ConvertirAViewModel());
        }
        public ActionResult Buscar()
        {
            return View();
        }
        public ActionResult Busqueda(string cliente)
        {
            Logger.Log("Paso por el action de Busqueda");
            var clientes = gestorClientes.Buscar(cliente);
            return View(clientes.ConvertirAViewModel());
        }
        public ActionResult EliminarPorDni(int id)
        {
            gestorClientes.Eliminar(id);
            return RedirectToAction("Listar");
        }
        public ActionResult EliminarPorNombreyApe(string apellido, string nombre)
        {
            gestorClientes.Eliminar(apellido, nombre);
            return RedirectToAction("Listar");
        }

    }
}