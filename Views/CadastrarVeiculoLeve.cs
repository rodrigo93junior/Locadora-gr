using System;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;

namespace View
{
    public class CadastrarVeiculoLeve : Form
    {
        LibTituloLabel lblTitulo;
        LibLabel lblMarca;
        LibTextBox marca;
        LibLabel lblModelo;
        LibTextBox modelo;
        LibLabel lblAno;
        LibTextBox ano;
        LibLabel lblPreco;
        LibTextBox preco;
        LibLabel lblCor;
        LibTextBox cor;
        LibButton btnSalvarVeiculoLeve;
        LibButton btnCancelar;
        public CadastrarVeiculoLeve()
        {
            this.Text = "Cadastro de Veículo Leve";

            lblTitulo = new LibTituloLabel("Cadastro de Novo Veículo Leve", new Point(180, 10), new Size(180, 40));

            lblMarca = new LibLabel("Marca:", new Point(20, 30), new Size(120, 15));

            marca = new LibTextBox(new Point(20, 50), new Size(300, 40));

            lblModelo = new LibLabel("Modelo:", new Point(20, 80), new Size(120, 15));


            modelo = new LibTextBox(new Point(20, 100), new Size(300, 40));

            lblAno = new LibLabel("Ano:", new Point(20, 120), new Size(120, 15));

            ano = new LibTextBox(new Point(20, 140), new Size(300, 40));

            lblPreco = new LibLabel("Preço:", new Point(20, 160), new Size(120, 15));


            preco = new LibTextBox(new Point(20, 180), new Size(300, 40));

            lblCor = new LibLabel("Cor:", new Point(20, 200), new Size(120, 15));

            cor = new LibTextBox(new Point(20, 220), new Size(300, 40));

            btnSalvarVeiculoLeve = new LibButton("Salvar", new Point(100, 300), new Size(100, 40));
            btnSalvarVeiculoLeve.Click += new EventHandler(this.botaoSalvarVeiculoLeve);


            btnCancelar = new LibButton("Cancelar", new Point(200, 300), new Size(100, 40));


            this.Size = new Size(540, 400);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblMarca);
            this.Controls.Add(marca);
            this.Controls.Add(lblModelo);
            this.Controls.Add(modelo);
            this.Controls.Add(lblAno);
            this.Controls.Add(ano);
            this.Controls.Add(lblPreco);
            this.Controls.Add(preco);
            this.Controls.Add(lblCor);
            this.Controls.Add(cor);
            this.Controls.Add(btnSalvarVeiculoLeve);
            this.Controls.Add(btnCancelar);
        }

        private void botaoSalvarVeiculoLeve(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente cadastrar o veículo?",
                "Confirmar Cadastro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Veículo Cadastrado!");
            }
            else if (resultado == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Veículo não cadastrado");
            }
            else
            {
                MessageBox.Show("Opção Incorreta");
            }
            this.Close();
        }
        private void botaoCancelar(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente cancelar?",
                "Confirmar Cadastro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Veículo não cadastrado");
            }
            else
            {
                MessageBox.Show("Opção Invalida!");
            }

            this.Close();
        }
    }
}