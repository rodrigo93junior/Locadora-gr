using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
        public static class Cliente
    {

        public static Model.Cliente NovoCliente(
            string Nome,
            string StringDataNascimento,
            string Cpf,
            string DiasRetorno
        )
        {
            
            Regex rgx = new("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$");
            if (!rgx.IsMatch(Cpf)){
                throw new Exception("C.P.F. Inválido");
            }

            DateTime DataNascimento;

            try {
                DataNascimento = Convert.ToDateTime(StringDataNascimento);
            } catch {
                throw new Exception("Data de Nascimento Inválida");
            }

            return new Model.Cliente(
                Nome,
                DataNascimento,
                Cpf,
                Convert.ToInt32(DiasRetorno)
            );
        }
       public static IEnumerable<Model.Cliente> ListarClientes () {
            return Model.Cliente.GetClientes ();
        }

        public static Model.Cliente GetCliente (int Id) {
            int ListLenght = Model.Cliente.GetCount();

            if (Id < 0 || ListLenght <= Id) {
                throw new Exception ("Id informado é inválido.");
            }

            return Model.Cliente.GetCliente (Id);
        }
    }
}