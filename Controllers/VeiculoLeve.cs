using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoLeve
    {
        public static Model.VeiculoLeve AdicionarVeiculoLeve(
            string Marca,
            string Modelo,
            string Ano,
            string Preco,
            string Cor
        )
        {
            int ConvertAno = Convert.ToInt32(Ano);
            double ConvertPreco = Convert.ToDouble(Preco);

            if (ConvertAno < 1990)
            {
                throw new Exception("Carro muito antigo");
            }

            if (ConvertPreco < 0)
            {
                throw new Exception("Valor não pode ser negativo");
            }

            return new Model.VeiculoLeve(
                Marca,
                Modelo,
                ConvertAno,
                ConvertPreco,
                Cor
            );
        }

        public static IEnumerable<Model.VeiculoLeve> GetVeiculosLeves()
        {
            return Model.VeiculoLeve.GetVeiculosLeves();
        }

        public static Model.VeiculoLeve GetVeiculoLeve(int Id)
        {
            int ListarVeiculosLeves = Model.VeiculoLeve.GetCount();

            if (Id < 0 || ListarVeiculosLeves < Id)
            {
                throw new Exception("Id informado é inválido.");
            }

            return Model.VeiculoLeve.GetVeiculoLeve(Id);
        }
    }
}