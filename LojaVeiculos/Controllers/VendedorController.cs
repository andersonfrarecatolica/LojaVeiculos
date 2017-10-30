using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VendedorController : Controller
    {

        private ApplicationDbContext _context;

        public VendedorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Vendedor
        public ActionResult Index()
        {
            var vendedores = _context.Vendedores.ToList();

            return View(vendedores);
        }

        public ActionResult Details(int id)
        {

            var vendedor = _context.Vendedores.SingleOrDefault(v => v.Id == id);

            if (vendedor == null)
            {
                return HttpNotFound();
            }

            return View(vendedor);
        }

        public ActionResult New()
        {
            var vendedor = new Vendedor();

            return View("VendedorForm", vendedor);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Vendedor vendedor) // recebemos um vendedor
        {

            if (!ModelState.IsValid)
            {
                return View("VendedorForm", vendedor);
            }

            if (vendedor.Id == 0)
            {
                // armazena o vendedor em memória
                _context.Vendedores.Add(vendedor);
            }
            else
            {
                var vendedorInDb = _context.Vendedores.Single(v => v.Id == vendedor.Id);

                vendedorInDb.Nome = vendedor.Nome;
                vendedorInDb.Cpf = vendedor.Cpf;
                vendedorInDb.Telefone = vendedor.Telefone;
                vendedorInDb.Email = vendedor.Email;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de vendedores
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var vendedor = _context.Vendedores.SingleOrDefault(v => v.Id == id);

            if (vendedor == null)
                return HttpNotFound();

            return View("VendedorForm", vendedor);
        }

    }


}