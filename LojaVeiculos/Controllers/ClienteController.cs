using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace LojaVeiculos.Controllers
{
    public class ClienteController : Controller
    {

        private ApplicationDbContext _context;

        public List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente {
                Id = 1,
                Nome = "Anderson Frare",
                Cpf = "070.932.119-84",
                DataNascimento = "19/09/1995",
                Email = "andersonfrare@hotmail.com",
                Telefone = "47-999658818",
                Rua = "Dr Arquimedes Dantas",
                Numero = "40",
                Bairro = "Vila Lenzi",
                Cidade = "Jaraguá do Sul", 
                Estado = "SC"
            }
        };

        public ClienteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers

        public ActionResult Index()
        {

            var clientes = _context.Clientes.ToList();

            return View(clientes);
                
        }
        
        public ActionResult Details(int id)
        {

            var cliente = _context.Clientes.ToList();

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

    }
}
 