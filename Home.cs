using System;

namespace csharp_vehicles {
    public class Program {
        public static void Main () {
            int opt;
            Console.WriteLine ("#####################################");
            Console.WriteLine ("###### GR Locações de Veiculos ######");
            Console.WriteLine ("#####################################");

            do {
                Console.WriteLine ("#################################");
                Console.WriteLine ("#    Digite a Opção Desejada    #");
                Console.WriteLine ("# 1 - Cadastrar Cliente         #");
                Console.WriteLine ("# 2 - Lista de Clientes         #");
                Console.WriteLine ("# 3 - Cadastrar Veículo Leve    #");
                Console.WriteLine ("# 4 - Lista de Veículos Leves   #");
                Console.WriteLine ("# 5 - Cadastrar Veículo Pesado  #");
                Console.WriteLine ("# 6 - Lista de Veículos Pesados #");
                Console.WriteLine ("# 7 - Cadastrar Locação         #");
                Console.WriteLine ("# 8 - Lista de Locações         #");
                Console.WriteLine ("# 9 - Importar Informações      #");
                Console.WriteLine ("# 0 - Sair                      #");
                Console.WriteLine ("#################################");

                opt = Convert.ToInt32 (Console.ReadLine ());
                switch (opt) {
                    case 0:
                        Console.WriteLine ("##### Obrigado pela sua preferência! #####");
                        break;
                    case 1:
                        View.Cliente.NovoCliente ();
                        break;
                    case 2:
                        View.Cliente.ListarClientes ();
                        break;
                    case 3:
                        View.VeiculoLeve.AdicionarVeiculoLeve ();
                        break;
                    case 4:
                        View.VeiculoLeve.ListarVeiculosLeves ();
                        break;
                    case 5:
                        View.VeiculoPesado.AdicionarVeiculoPesado ();
                        break;
                    case 6:
                        View.VeiculoPesado.ListarVeiculosPesados ();
                        break;
                    case 7:
                        View.Locacao.CriarLocacao ();
                        break;
                    case 8:
                        View.Locacao.ListarLocacao ();
                        break;
                    case 9:
                        View.Importacao.BDImportacao ();
                        break;
                    default:
                        Console.WriteLine ("Operação Inválida.");
                        break;
                }
            } while (opt != 0);
        }

    }
}
