using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVeiculos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public int VeiculoId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }
        public string NotaFiscal { get; set; }
        public string Data { get; set; }
        public double Valor { get; set; }
    }
}