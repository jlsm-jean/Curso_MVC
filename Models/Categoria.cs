﻿using Curso_MVC.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_MVC.Models
{
    public class Categoria
    {
        
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatátio")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
   
    }
}