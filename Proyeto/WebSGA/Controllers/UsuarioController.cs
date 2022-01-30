using Microsoft.AspNetCore.Mvc;
using Proyecto.Entidades;
using ProyectoDB;
using System.Collections.Generic;

namespace WebSGA.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Conexion db;
        public UsuarioController(Conexion db) 
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Usuario> listaUsuarios = db.Usuarios;
            return View(listaUsuarios);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
