using System;
using System.Collections.Generic;

namespace View {
    public class Cliente{
        public static void NovoCliente(){
            Console.WriteLine("Digite o nome da pessoa: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite a Data de Nascimento da pessoa: ");
            string DataNascimento = Console.ReadLine();
            Console.WriteLine("Digite o CPF da pessoa: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Número de Dias para Devolução: ");
            string DiasRetorno = Console.ReadLine();
            try {
                Controller.Cliente.NovoCliente (Nome, DataNascimento, Cpf, DiasRetorno);
            } catch (Exception e) {
                Console.WriteLine ($"Informações digitadas são incorretas: {e.Message}");
            }
        }
        public static void ListarClientes () {            
            foreach (Model.Cliente cliente in Controller.Cliente.ListarClientes ()) {
                Console.WriteLine ("---------------------------");
                Console.WriteLine (cliente);
            }
            Console.WriteLine ("---------------------------\n");
        }
    }
}