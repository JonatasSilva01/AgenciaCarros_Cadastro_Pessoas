using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public interface IBase
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCpf(string cpf);
        void Gravar();
    }
}
