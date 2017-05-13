using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMiProyecto.Models.AccesoDatos;

namespace WebMiProyecto.Models
{
    public class GestorClientes
    {
        RepositorioClientes repo = new RepositorioClientes();

        public void Guardar(Cliente cliente)
        {
            repo.Guardar(cliente);
        }
        public List<Cliente> Listar()
        {
            return repo.Listar();
        }

        public List<Cliente> Buscar(string cliente)
        {
            return repo.Buscar(cliente);
        }

        public void Eliminar(int id)
        {
            repo.Eliminar(id);
        }

        public void Eliminar(string apellido, string nombre)
        {
            repo.Eliminar(apellido, nombre);
        }

    }
}