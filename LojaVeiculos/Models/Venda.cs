using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace LojaVeiculos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        

        [Required]
        [Display(Name = "Veiculo")]
        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }


        [Required]
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }

        public Vendedor Vendedor { get; set; }

        [Required]
        [Display(Name = "Nota Fiscal")]
        public string NotaFiscal { get; set; }

        [Required]
        [Display(Name = "Data")]
        public DateTime? Data { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public double? Valor { get; set; }
    }
}