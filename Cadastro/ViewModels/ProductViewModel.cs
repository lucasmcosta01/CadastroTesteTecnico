using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Cadastro.ViewModels
{

    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "O nome do produto é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O valor é requerido.")]
        public decimal Value { get; set; }

        [Display(Name = "Disponível")]
        [Required(ErrorMessage = "")]
        public bool Active { get; set; }

        [Display(Name = "Nome")]
        [ForeignKey("ClienttId")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

    }

}

