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
    public class VendaController : Controller
    {

        private ApplicationDbContext _context;

        public VendaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Venda
        public ActionResult Index()
        {
            var vendas = _context.Vendas.Include(a => a.Veiculo).Include(b => b.Cliente).Include(c => c.Vendedor).ToList();
            return View(vendas);

        }

        public ActionResult Details(int id)
        {

            var vendas = _context.Vendas.Include(a => a.Veiculo).Include(b => b.Cliente).Include(c => c.Vendedor).SingleOrDefault(a => a.Id == id);

            if (vendas == null)
            {
                return HttpNotFound();
            }

            return View(vendas);
        }

    }
}