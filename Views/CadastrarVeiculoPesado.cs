using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CadastrarVeiculoPesado : Form
    {
        Label lblTitulo;
        Label lblMarca;
        TextBox marca;
        Label lblModelo;
        TextBox modelo;
        Label lblAno;
        TextBox ano;
        Label lblPreco;
        TextBox preco;
        Label lblRestricao;
        TextBox restricao;
        Button btnSalvarVeiculoPesado;
        Button btnCancelar;
        public CadastrarVeiculoPesado()
        {
            this.Text = "Cadastro de Veículo Pesado";

            lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Novo Veículo Pesado";
            lblTitulo.Location = new Point(180, 10);
            lblTitulo.Size = new Size(200, 40);

            lblMarca = new Label();
            lblMarca.Text = "Marca:";
            lblMarca.Location = new Point(20, 30);
            lblMarca.Size = new Size(120, 15);

            marca = new TextBox();
            marca.Location = new Point(20, 50);
            marca.Size = new Size(300, 40);

            lblModelo = new Label();
            lblModelo.Text = "Modelo:";
            lblModelo.Location = new Point(20, 80);
            lblModelo.Size = new Size(120, 15);

            modelo = new TextBox();
            modelo.Location = new Point(20, 100);
            modelo.Size = new Size(300, 40);

            lblAno = new Label();
            lblAno.Text = "Ano:";
            lblAno.Location = new Point(20, 120);
            lblAno.Size = new Size(120, 15);

            ano = new TextBox();
            ano.Location = new Point(20, 140);
            ano.Size = new Size(300, 40);

            lblPreco = new Label();
            lblPreco.Text = "Preço:";
            lblPreco.Location = new Point(20, 160);
            lblPreco.Size = new Size(120, 15);

            preco = new TextBox();
            preco.Location = new Point(20, 180);
            preco.Size = new Size(300, 40);

            lblRestricao = new Label();
            lblRestricao.Text = "Restricao:";
            lblRestricao.Location = new Point(20, 200);
            lblRestricao.Size = new Size(120, 15);

            restricao = new TextBox();
            restricao.Location = new Point(20, 220);
            restricao.Size = new Size(300, 40);

            btnSalvarVeiculoPesado = new Button();
            btnSalvarVeiculoPesado.Text = "Salvar";
            btnSalvarVeiculoPesado.Location = new Point(100, 300);
            btnSalvarVeiculoPesado.Size = new Size(100, 40);
            btnSalvarVeiculoPesado.Click += new EventHandler(this.botaoSalvarVeiculoPesado);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(200, 300);
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.Click += new EventHandler(this.botaoCancelar);


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
            this.Controls.Add(lblRestricao);
            this.Controls.Add(restricao);
            this.Controls.Add(btnSalvarVeiculoPesado);
            this.Controls.Add(btnCancelar);
        }

        private void botaoSalvarVeiculoPesado(object sender, EventArgs e)
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