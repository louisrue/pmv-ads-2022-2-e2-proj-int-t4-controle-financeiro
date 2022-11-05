﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZCaixaV5.Models
{
    public class Usuario
    {

        [Required(ErrorMessage = "Informe um usuário.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Informe seu nome.")]

        public string Nome { get; set; }

        public string UltimoNome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma senha.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Obrigatório informar um email.")]
        public string Email { get; set; }

        public string Telefone { get; set; }
        [Required(ErrorMessage = "Obrigatório informar sua Data de Nascimento.")]
        public DateTime DataNascimento { get; set; }

    }
}
