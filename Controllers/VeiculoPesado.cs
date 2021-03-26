using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoPesado
    {
        public static Model.VeiculoPesado AdicionarVeiculoPesado(
            string Marca,
            string Modelo,
            string Ano,
            string Preco,
            string Restricoes
        )
        {
            int ConvertAno = Convert.ToInt32(Ano);
            double ConvertPreco = Convert.ToDouble(Preco);

            if (ConvertAno < 2018)
            {
                throw new Exception("Carro fora do padrão!");
            }
            if (ConvertPreco < 0)
            {
                throw new Exception("Preço incorreto!");
            }
            return new Model.VeiculoPesado(
                Marca,
                Modelo,
                ConvertAno,
                ConvertPreco,
                Restricoes
            );
        }
        public static IEnumerable<Model.VeiculoPesado> GetVeiculoPesados () {
            return Model.VeiculoPesado.GetVeiculosPesados ();
        }

        public static Model.VeiculoPesado GetVeiculoPesado (int Id) {
            int ListLenght = Model.VeiculoPesado.GetCount();

            if (Id < 0 || ListLenght <= Id) {
                throw new Exception ("Id informado é inválido.");
            }

            return Model.VeiculoPesado.GetVeiculoPesado (Id);
        }
    }
}