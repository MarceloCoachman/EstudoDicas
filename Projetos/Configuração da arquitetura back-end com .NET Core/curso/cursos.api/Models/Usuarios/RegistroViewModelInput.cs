﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursos.api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Email é obrigatorio")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatoria")]
        public string Senha { get; set; }

    }
}