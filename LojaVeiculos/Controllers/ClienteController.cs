﻿using LojaVeiculos.Models;
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

            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        public ActionResult New()
        {
            var cliente = new Cliente();

            return View("ClienteForm", cliente);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Cliente cliente) // recebemos um cliente
        {

            if (!ModelState.IsValid)
            {
                return View("ClienteForm", cliente);
            }

            if (cliente.Id == 0)
            {
                // armazena o cliente em memória
                _context.Clientes.Add(cliente);
            }
            else
            {
                var customerInDb = _context.Clientes.Single(c => c.Id == cliente.Id);

                customerInDb.Nome = cliente.Nome;
                customerInDb.Cpf = cliente.Cpf;
                customerInDb.Telefone = cliente.Telefone;
                customerInDb.Email = cliente.Email;
                customerInDb.DataNascimento = cliente.DataNascimento;
                customerInDb.Rua = cliente.Rua;
                customerInDb.Numero = cliente.Numero;
                customerInDb.Bairro = cliente.Bairro;
                customerInDb.Cidade = cliente.Cidade;
                customerInDb.Estado = cliente.Estado;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View("ClienteForm", cliente);
        }

    }
}
 