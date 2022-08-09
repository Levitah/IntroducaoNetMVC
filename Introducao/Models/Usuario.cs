using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, ErrorMessage = "Insira uma informação")]
        public string Nome { get; set; }
        [Range(18, 70, ErrorMessage = "A idade deve ser entre 18 e 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.! #$%&'*+/=? ^_`{|}~-]+@[a-zA-Z0-9-]+(?:\. [a-zA-Z0-9-]+)*$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
        [RegularExpression(@"[A-z]{5,15}", ErrorMessage = "Somente letras, com tamanho mínimo de 5 e máximo de 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este Login já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não são iguais")]
        public string ConfirmarSenha { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação")]
        public string Observacoes { get; set; }
    }
}