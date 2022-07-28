using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Modelo
{
    public class Usuario : Base
    {
        public void LerUsuario()
        {
            Console.WriteLine("=============Painel de Usuario=============");
            Base us = new Usuario();
            Console.WriteLine("Escreva seu nome: ");
            us.Name = Console.ReadLine();
            Console.WriteLine("Escreva seu CPF: ");
            us.Cpf = Console.ReadLine();
            Console.WriteLine("Escreva seu Telefone: ");
            us.Telefone = Console.ReadLine();
            Console.Clear();
            us.Gravar();

            foreach (Base cl in new Usuario().SetGenericReading())
            {
                Console.WriteLine(cl.Name);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.Cpf);
                Console.WriteLine("============================================");
            }
        }
    }
}
