﻿using System;

namespace VerificaPar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declaração da variável do tipo inteiro
           int numero;

           Console.WriteLine ("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine ("O número digitado é par!");
        
        }
    }
}
