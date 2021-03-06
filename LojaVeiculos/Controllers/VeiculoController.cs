﻿using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        private ApplicationDbContext _context;

        public VeiculoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Veiculo
        public ActionResult Index()
        {
            var veiculos = _context.Veiculos.ToList();
            if (User.IsInRole("CanManageData"))
                return View(veiculos);
            return View("ReadOnlyIndex", veiculos);
            

        }

        public ActionResult Details(int id)
        {

            var veiculo = _context.Veiculos.SingleOrDefault(v => v.Id == id);

            if (veiculo == null)
            {
                return HttpNotFound();
            }

            return View(veiculo);
        }

        [Authorize(Roles = "CanManageData")]
        public ActionResult New()
        {
            var veiculo = new Veiculo();

            return View("VeiculoForm", veiculo);
        }

        [Authorize(Roles = "CanManageData")]
        [HttpPost] // só será acessada com POST
        public ActionResult Save(Veiculo veiculo) // recebemos um cliente
        {

            if (!ModelState.IsValid)
            {
                return View("VeiculoForm", veiculo);
            }

            if (veiculo.Id == 0)
            {
                // armazena o cliente em memória
                _context.Veiculos.Add(veiculo);
            }
            else
            {
                var veiculoInDb = _context.Veiculos.Single(v => v.Id == veiculo.Id);

                veiculoInDb.Tipo = veiculo.Tipo;
                veiculoInDb.Marca = veiculo.Marca;
                veiculoInDb.Modelo = veiculo.Modelo;
                veiculoInDb.Ano = veiculo.Ano;
                veiculoInDb.Placa = veiculo.Placa;
                veiculoInDb.Cor = veiculo.Cor;
                veiculoInDb.Descricao = veiculo.Descricao;
                veiculoInDb.Valor = veiculo.Valor;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "CanManageData")]
        public ActionResult Edit(int id)
        {
            var veiculo = _context.Veiculos.SingleOrDefault(v => v.Id == id);

            if (veiculo == null)
                return HttpNotFound();

            return View("VeiculoForm", veiculo);
        }

        [Authorize(Roles = "CanManageData")]
        public ActionResult Delete(int id)
        {
            var veiculo = _context.Veiculos.SingleOrDefault(c => c.Id == id);

            if (veiculo == null)
                return HttpNotFound();

            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

    }
}