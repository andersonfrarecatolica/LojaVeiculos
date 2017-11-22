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

            if (User.IsInRole("CanManageData"))
                return View(vendedores);
            return View("ReadOnlyIndex", vendedores);

           
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

        [Authorize(Roles = "CanManageData")]
        public ActionResult New()
        {
            var vendedor = new Vendedor();

            return View("VendedorForm", vendedor);
        }

        [Authorize(Roles = "CanManageData")]
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

        [Authorize(Roles = "CanManageData")]
        public ActionResult Edit(int id)
        {
            var vendedor = _context.Vendedores.SingleOrDefault(v => v.Id == id);

            if (vendedor == null)
                return HttpNotFound();

            return View("VendedorForm", vendedor);
        }

        [Authorize(Roles = "CanManageData")]
        public ActionResult Delete(int id)
        {
            var vendedor = _context.Vendedores.SingleOrDefault(c => c.Id == id);

            if (vendedor == null)
                return HttpNotFound();

            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

    }

}