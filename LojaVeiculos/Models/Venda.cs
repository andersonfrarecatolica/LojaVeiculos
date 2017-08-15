using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVeiculos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public string NotaFiscal { get; set; }
        public string Data { get; set; }
        public double Valor { get; set; }
    }
}