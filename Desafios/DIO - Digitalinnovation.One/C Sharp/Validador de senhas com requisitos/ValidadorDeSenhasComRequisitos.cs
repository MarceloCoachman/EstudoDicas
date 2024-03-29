﻿using System;
using System.Text.RegularExpressions;

namespace Validador_de_senhas_com_requisitos
{
    class ValidadorDeSenhasComRequisitos
    {
        static void Main(string[] args)
        {
           while (true)
           {

             String senha = Console.ReadLine();

             if ( string.IsNullOrEmpty(senha)) break;

            Regex requisitos = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
            Match validar = requisitos.Match(senha);
      
                if (validar.Success) {
                    Console.WriteLine("Senha valida.");
                    Console.WriteLine();
                } else {
                    Console.WriteLine("Senha invalida.");
                    Console.WriteLine();
                }
           } 
        }
    }
}



/*

Desafio
Pedro e Fernando são os desenvolvedores em uma stratup e vão desenvolver o novo sistema de cadastro, e pediram a sua ajuda. 
Sua task é fazer o código que valide as senhas que são cadastradas, para isso você deve atentar aos requisitos a seguir:

* A senha deve conter, no mínimo, uma letra maiúscula, uma letra minúscula e um número;
* A mesma não pode ter nenhum caractere de pontuação, acentuação ou espaço;
* Além disso, a senha pode ter de 6 a 32 caracteres.

Entrada
A entrada contém vários casos de teste e termina com final de arquivo. Cada linha tem uma string S, correspondente a senha que é inserida pelo usuário no momento do cadastro.

Saída
A saída contém uma linha, que pode ser “Senha valida.”, caso a senha tenha cada item dos requisitos solicitados anteriormente, ou “Senha invalida.”, se um ou mais requisitos não forem atendidos.

 
Exemplo de Entrada	                        Exemplo de Saída
Digital Innovation One                      Senha invalida.
AbcdEfgh99                                  Senha valida.
DigitalInnovationOne123                     Senha valida.
Digital Innovation One 123                  Senha invalida.
Aass9                                       Senha invalida.
Aassd9                                      Senha valida.



*/