using System;
using Modelo;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    public class PainelAgenciaCarros
    {
        public int Resposta { get; set; }

        public bool painelAgenciaDigital(int res) 
        { 
            Resposta = res;
            if(Resposta == 1)
            {
                int PARAR_PROGRAMA = 0;
                int USUARIO_RESPOSTA = 1;
                int CLIENTE_USUARIO = 2;
                int MANDAR_EMAIL = 3;

                Console.Clear();
                Console.WriteLine("================================================================");
                Console.WriteLine($"Parar programa é {PARAR_PROGRAMA} \n" +
                    $"Cadastrar Usuario é {USUARIO_RESPOSTA}\n" +
                    $"Cadastrar Cliente é {CLIENTE_USUARIO}\n" +
                    $"Mandar Email é {MANDAR_EMAIL}");
                Console.Write("Digite qual Opção que deseja continuar: "); var r = int.Parse(Console.ReadLine());
                Console.WriteLine("================================================================");
                Console.Clear();
                Console.WriteLine("============================= Menu =============================");
                        if (r == 0) Console.WriteLine("Programa Finalizado!"); 
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
                        if(r == 3)
                        {
                            Console.Write("Origem do Email: "); Email.Instancia.Origin = Console.ReadLine() + "\n";
                            Console.Write("Titulo do Email: "); Email.Instancia.Titulo = Console.ReadLine() + "\n";
                            Console.Write("Destino do Email: "); Email.Instancia.Destino = Console.ReadLine() + "\n";
                            Console.Write("Descrição do Email: "); Email.Instancia.Corpo = Console.ReadLine() + "\n";
                            Console.Clear();
                            Email.Instancia.EnviarEmail();
                        }
                Console.WriteLine("=================================================================");

                return true;
            }
            else if(Resposta == 2)
            {
                Console.Clear();
                Console.WriteLine("Programa Finalizado");
                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}
