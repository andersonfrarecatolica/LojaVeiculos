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
            
            if (User.IsInRole("CanManageData"))
                return View(vendas);
            return View("ReadOnlyIndex", vendas);

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

        [Authorize(Roles = "CanManageData")]
        public ActionResult New()
        {


            var viewModel = new VendaIndexViewModel
            {
                Venda = new Venda(),
                Veiculos = _context.Veiculos.ToList(),
                Clientes = _context.Clientes.ToList(),
                Vendedores = _context.Vendedores.ToList(),
            };

            return View("VendaForm", viewModel);
        }

        [Authorize(Roles = "CanManageData")]
        [HttpPost] // só será acessada com POST
        public ActionResult Save(Venda venda) // recebemos um cliente
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new VendaIndexViewModel
                {
                    Venda = venda,
                    Veiculos = _context.Veiculos.ToList(),
                    Clientes = _context.Clientes.ToList(),
                    Vendedores = _context.Vendedores.ToList()

                };

                return View("VendaForm", viewModel);

            }

            if (venda.Id == 0)
            {
                // armazena o cliente em memória
                _context.Vendas.Add(venda);
            }
            else
            {
                var vendaInDb = _context.Vendas.Single(v => v.Id == venda.Id);

                vendaInDb.VeiculoId = venda.VeiculoId;
                vendaInDb.ClienteId = venda.ClienteId;
                vendaInDb.VendedorId = venda.VendedorId;
                vendaInDb.NotaFiscal = venda.NotaFiscal;
                vendaInDb.Data = venda.Data;
                vendaInDb.Valor = venda.Valor;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "CanManageData")]
        public ActionResult Edit(int id)
        {
            var venda = _context.Vendas.SingleOrDefault(c => c.Id == id);

            if (venda == null)
                return HttpNotFound();

            var viewModel = new VendaIndexViewModel
            {
                Venda = venda,
                Veiculos = _context.Veiculos.ToList(),
                Clientes = _context.Clientes.ToList(),
                Vendedores = _context.Vendedores.ToList(),

            };

            return View("VendaForm", viewModel);
        }

        [Authorize(Roles = "CanManageData")]
        public ActionResult Delete(int id)
        {
            var venda = _context.Vendas.SingleOrDefault(c => c.Id == id);

            if (venda == null)
                return HttpNotFound();

            _context.Vendas.Remove(venda);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

    }
}