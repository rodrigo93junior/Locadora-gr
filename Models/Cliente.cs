using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repositorio;

namespace Model
{
    public class Cliente
    {
        public int Id { set; get; } // Identificador Único (ID)
        [Required]
        public string Nome { set; get; } // Nome
        public DateTime DataNascimento { set; get; } // Data de Nascimento
        public string Cpf { set; get; } // C.P.F.
        public int DiasRetorno { set; get; } // Dias para Devolução

        public Cliente()
        {

        }
        public Cliente(
            string Nome,
            DateTime DataNascimento,
            string Cpf,
            int DiasRetorno
        )
        {
            Context db = new Context();
            //this.Id = Clientes.Count;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Cpf = Cpf;
            this.DiasRetorno = DiasRetorno;

            db.Clientes.Add(this);
            db.SaveChanges();
        }

        public static Cliente AtualizarClientes(
            Cliente cliente,
            string stringValor,
            string stringCampo
        )
        {
            int Campo = Convert.ToInt32(stringCampo);
            switch (Campo)
            {
                case 1:
                    cliente.Nome = stringValor;
                    break;
                case 2:
                    cliente.Cpf = stringValor;
                    break;

            }
            Context db = new Context();
            db.Clientes.Update(cliente);
            db.SaveChanges();
            return cliente;
        }



        public override string ToString()
        {
            return String.Format(
                "Id: {0} - Nome: {1} - Data de Nascimento: {2:d}",
                this.Id,
                this.Nome,
                this.DataNascimento
            );
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Cliente Cliente = (Cliente)obj;
            return this.GetHashCode() == Cliente.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }

        public static IEnumerable<Cliente> GetClientes()
        {
            Context db = new Context();
            return from cliente in db.Clientes select cliente;
        }

        public static int GetCount()
        {
            return GetClientes().Count();
        }

        public static void AddCliente(Cliente cliente)
        {
            Context db = new Context();
            db.Clientes.Add(cliente);
        }

        public static Cliente GetCliente(int Id)
        {
            Context db = new Context();
            IEnumerable<Cliente> query = from cliente in db.Clientes where cliente.Id == Id select cliente;

            return query.First();

        }
    }
}
