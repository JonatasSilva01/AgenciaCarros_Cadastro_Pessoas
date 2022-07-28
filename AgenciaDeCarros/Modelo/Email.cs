using System;
using System.Collections.Generic;
using System.Text;

// Classe Singleton
// Uma ideia de como mandar e-mail em uma aplicação real

namespace Modelo
{
    public class Email
    {
        private Email() { }

        private static Email instancia;

        public string Corpo;
        public string Titulo;
        public string Origin;
        public string Destino;

        public void EnviarEmail()
        {
            Console.WriteLine("\n" +
                "Enviando email para: " + Destino + "\n" +
                "Com a origin: " + Origin + "\n" +
                "Com o Titulo: " + Titulo + "\n" +
                "Com o corpo: " + Corpo + "\n");

        }

        public static Email Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
        
    }
}
