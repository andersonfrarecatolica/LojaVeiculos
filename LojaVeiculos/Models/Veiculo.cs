using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace LojaVeiculos.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor")]
        public double Valor { get; set; }
    }
}