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
            Base Us = new Usuario();
            Console.WriteLine("Escreva seu nome: ");
            Us.Name = Console.ReadLine();
            Console.WriteLine("Escreva seu CPF: ");
            Us.Cpf = Console.ReadLine();
            Console.WriteLine("Escreva seu Telefone: ");
            Us.Telefone = Console.ReadLine();
            Console.Clear();
            Us.Gravar();

            foreach (Base us in new Usuario().SetGenericReading())
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Nome: " + us.Name);
                Console.WriteLine("Telefone: " + us.Telefone);
                Console.WriteLine("CPF: " + us.Cpf);
                Console.WriteLine("============================================");
            }
        }
    }
}
