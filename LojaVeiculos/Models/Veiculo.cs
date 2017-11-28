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

        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Ano")]
        public int? Ano { get; set; }

        [Required]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Required]
        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public double? Valor { get; set; }
    }
}