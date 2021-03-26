using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Locacao
    {
        public static Model.Locacao NovaLocacao(
            string IdCliente,
            string StringDataLocacao,
            List<Model.VeiculoLeve> VeiculosLeves,
            List<Model.VeiculoPesado> VeiculosPesados
        ){
            Model.Cliente Cliente = Controller.Cliente
                .GetCliente(Convert.ToInt32(IdCliente));

            DateTime DataLocacao;

            try {
                DataLocacao = Convert.ToDateTime(StringDataLocacao);
            } catch {
                DataLocacao = DateTime.Now;
            }

            if (DataLocacao > DateTime.Now)
            {
                throw new Exception("Data de Locação não pode ser maior que a data atual");
            }

            return new Model.Locacao (Cliente, DataLocacao, VeiculosLeves, VeiculosPesados);
        }

        public static IEnumerable<Model.Locacao> GetLocacoes () {
            return Model.Locacao.GetLocacoes ();
        }
    }
}
