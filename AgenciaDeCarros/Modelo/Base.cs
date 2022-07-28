using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Modelo
{
    public class Base : IBase
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }



        public void SetNome(string nome) { this.Name = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCpf(string cpf) { this.Cpf = cpf; }

        public Base(string name, string telefone, string cpf)
        {
            Name = name;
            Telefone = telefone;
            Cpf = cpf;
        }

        public string Diretorio()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"] + this.GetType() + ".txt";
        }

        public virtual void Gravar()
        {
            var dados = this.SetGenericReading();
            dados.Add(this);

            StreamWriter w = new StreamWriter(Diretorio());
            w.WriteLine("nome;telefone;cpf;");
            foreach (Base d in dados)
            {
                var linha = d.Name + ";" + d.Telefone + ";" + d.Cpf + ";";
                w.WriteLine(linha);
            }
            w.Close();
        }

        public List<IBase> SetGenericReading()
        {
            var list = new List<IBase>();
            if (File.Exists(Diretorio()))
            {
                using (StreamReader arquivo = File.OpenText(Diretorio()))
                {
                    string linha;
                    int i = 0;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseDirection = linha.Split(";");

                        var b = (IBase)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseDirection[0]);
                        b.SetTelefone(baseDirection[1]);
                        b.SetCpf(baseDirection[2]);

                        //var baseGenericObject = new Base(baseDirection[0], baseDirection[1], baseDirection[2]);
                        list.Add(b);
                    }
                }
            }

            return list;
        }

        public Base()
        {
            Id = Guid.NewGuid();
        }
    }
}
