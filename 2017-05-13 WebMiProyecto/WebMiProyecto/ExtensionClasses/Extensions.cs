using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMiProyecto.ExtensionClasses
{
    public static class Extensions
    {

        public static Models.Cliente ConvertirAModelo(this ViewModel.ClienteViewModel clienteviewmodel)
        {
            var cliente = new Models.Cliente
            {
                Apellido = clienteviewmodel.Apellido,
                Nombre = clienteviewmodel.Nombre,
                Edad = clienteviewmodel.Edad,
                Email = clienteviewmodel.Email
            };
            return cliente;
        }

        public static List<ViewModel.ClienteViewModel> ConvertirAViewModel(this List<Models.Cliente> clientes)
        {
            var listaDeViewModel = new List<ViewModel.ClienteViewModel>();
            foreach(var clienteDelModelo in clientes)
            {
                var clienteDeViewModel = new ViewModel.ClienteViewModel
                {
                    ClienteId = clienteDelModelo.Id,
                    Apellido = clienteDelModelo.Apellido,
                    Nombre = clienteDelModelo.Nombre,
                    Edad = clienteDelModelo.Edad,
                    Email = clienteDelModelo.Email
                };
                listaDeViewModel.Add(clienteDeViewModel);
            }
            return listaDeViewModel;
        }


    }
}