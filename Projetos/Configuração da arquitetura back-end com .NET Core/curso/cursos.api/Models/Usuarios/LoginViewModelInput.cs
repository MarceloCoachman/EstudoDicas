﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursos.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
