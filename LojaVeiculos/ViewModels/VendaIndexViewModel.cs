using LojaVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVeiculos.ViewModels
{
    public class VendaIndexViewModel
    {
        public List<Veiculo> Veiculos { get; set; }
        public List<Vendedor> Vendedores { get; set; }
        public List<Cliente> Clientes { get; set; }

        public Venda Venda { get; set; }

    }
}