using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVeiculos.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}