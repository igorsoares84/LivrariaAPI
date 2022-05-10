﻿using System.ComponentModel.DataAnnotations;

namespace LivrariaAPI.Data.DTOs
{
    public class CreateLivroDTO
    {
        [Required(ErrorMessage = "Titulo do livro não pode estar em branco.")]
        public string Titulo { get; set; }
        [Range(1, 9999, ErrorMessage = "Quantidade de páginas deve ser maior que zero.")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "Genêro do livro não pode estar em branco.")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Autor do livro não pode estar em branco.")]
        public string Autor { get; set; }
    }
}
