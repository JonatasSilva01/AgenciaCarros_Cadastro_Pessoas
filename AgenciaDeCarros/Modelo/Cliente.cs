using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Cliente : Base
    {
        public void LerCliente()
        {
            Console.WriteLine("=============Painel de Cadastro=============");
            Base a = new Cliente();
            Console.WriteLine("Escreva seu nome: ");
            a.Name = Console.ReadLine();
            Console.WriteLine("Escreva seu CPF:");
            a.Cpf = Console.ReadLine();
            Console.WriteLine("Escreva seu Telefone:");
            a.Telefone = Console.ReadLine();
            Console.Clear();
            a.Gravar();

            foreach (Base cl in new Cliente().SetGenericReading())
            {
                Console.WriteLine(cl.Name);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.Cpf);
                Console.WriteLine("============================================");
            }
        }
    }
}
