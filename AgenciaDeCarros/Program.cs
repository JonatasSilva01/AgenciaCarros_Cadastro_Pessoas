using Modelo;
using System;

namespace AgenciaDeCarros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================ Email =============================");
            Email.Instancia.Titulo = "Curso em Video";
            Email.Instancia.Corpo = "Olá vim pegar meu curso de C#";
            Email.Instancia.Origin = "jonsilvasantos7@gmail.com";
            Email.Instancia.Destino = "jhownsantossilva@ggmail.com";
            Email.Instancia.EnviarEmail();
            Console.WriteLine("================================================================");
            /*
            Console.WriteLine("============================= Menu =============================");
            Console.WriteLine("\n" +
                "       1 - Para Registrar Usuario \n" +
                "       2 - Para Registar Cliente\n");
            Console.Write("     Pode digitar --> ");
            var r = int.Parse(Console.ReadLine());
            if (r == 1) 
            {
                Usuario us = new Usuario();
                us.LerUsuario();
            }
            if (r == 2) 
            { 
                Cliente cl = new Cliente();
                cl.LerCliente();
            }
            Console.WriteLine("=================================================================");
            */
        }
    }
}
