using System;
using System.Windows.Forms;
using System.Drawing;


namespace View
{
    public class Menu : Form
    {
        PictureBox pbImagem;
        public Menu()
        {
            this.Text = "GR - Locadora de Veículos";

            pbImagem = new PictureBox();
            pbImagem.Size = new Size(200, 200);
            pbImagem.Location = new Point(300,250);
            pbImagem.Load("gr.jpg");
            pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            Label lblTitulo = new Label();
            lblTitulo.Text = "Bem vindo!";
            lblTitulo.Location = new Point(220, 10);
            lblTitulo.Size = new Size(80, 40);

            Label lblSubTitulo = new Label();
            lblSubTitulo.Text = "Cadastros:";
            lblSubTitulo.Location = new Point(20, 50);
            lblSubTitulo.Size = new Size(80, 20);

            Button btCadastrarLocacao = new Button();
            btCadastrarLocacao.Text = "Cadastrar Locação";
            btCadastrarLocacao.Location = new Point(20, 80);
            btCadastrarLocacao.Size = new Size(200, 40);
            btCadastrarLocacao.Click += new EventHandler(this.btCadastrarLocacao);

            Button btCadastrarCliente = new Button();
            btCadastrarCliente.Text = "Cadastrar Cliente";
            btCadastrarCliente.Location = new Point(20, 130);
            btCadastrarCliente.Size = new Size(200, 40);
            btCadastrarCliente.Click += new EventHandler(this.btCadastrarCliente);

            Button btCadastrarVeiculoLeve = new Button();
            btCadastrarVeiculoLeve.Text = "Cadastrar Veículo Leve";
            btCadastrarVeiculoLeve.Location = new Point(20, 180);
            btCadastrarVeiculoLeve.Size = new Size(200, 40);
            btCadastrarVeiculoLeve.Click += new EventHandler(this.btCadastrarVeiculoLeve);

            Button btCadastrarVeiculoPesado = new Button();
            btCadastrarVeiculoPesado.Text = "Cadastrar Veículo Pesado";
            btCadastrarVeiculoPesado.Location = new Point(20, 230);
            btCadastrarVeiculoPesado.Size = new Size(200, 40);
            btCadastrarVeiculoPesado.Click += new EventHandler(this.btCadastrarVeiculoPesado);

            Label lblSubTituloVisualizacao = new Label();
            lblSubTituloVisualizacao.Text = "Visualização:";
            lblSubTituloVisualizacao.Location = new Point(300, 50);
            lblSubTituloVisualizacao.Size = new Size(80, 20);

            Button btListarCliente = new Button();
            btListarCliente.Text = "Listar Cliente";
            btListarCliente.Location = new Point(300, 80);
            btListarCliente.Size = new Size(200, 40);

            Button btListarVeiculoLeve = new Button();
            btListarVeiculoLeve.Text = "Listar Veículo Leve";
            btListarVeiculoLeve.Location = new Point(300, 130);
            btListarVeiculoLeve.Size = new Size(200, 40);

            Button btListarVeiculoPesado = new Button();
            btListarVeiculoPesado.Text = "Listar Veículo Pesado";
            btListarVeiculoPesado.Location = new Point(300, 180);
            btListarVeiculoPesado.Size = new Size(200, 40);

            Label lblSubTituloEditar = new Label();
            lblSubTituloEditar.Text = "Editar:";
            lblSubTituloEditar.Location = new Point(20, 290);
            lblSubTituloEditar.Size = new Size(80, 20);

            Button btEditarCliente = new Button();
            btEditarCliente.Text = "Editar Cliente";
            btEditarCliente.Location = new Point(20, 320);
            btEditarCliente.Size = new Size(200, 40);

            Button btEditarVeiculoLeve = new Button();
            btEditarVeiculoLeve.Text = "Editar Veículo Leve";
            btEditarVeiculoLeve.Location = new Point(20, 370);
            btEditarVeiculoLeve.Size = new Size(200, 40);

            Button btEditarVeiculoPesado = new Button();
            btEditarVeiculoPesado.Text = "Editar Veículo Pesado";
            btEditarVeiculoPesado.Location = new Point(20, 420);
            btEditarVeiculoPesado.Size = new Size(200, 40);


            this.Size = new Size(540, 520);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(pbImagem);
            this.Controls.Add(lblSubTitulo);
            this.Controls.Add(btCadastrarLocacao);
            this.Controls.Add(btCadastrarCliente);
            this.Controls.Add(btCadastrarVeiculoLeve);
            this.Controls.Add(btCadastrarVeiculoPesado);

            this.Controls.Add(lblSubTituloVisualizacao);
            this.Controls.Add(btListarCliente);
            this.Controls.Add(btListarVeiculoLeve);
            this.Controls.Add(btListarVeiculoPesado);

            this.Controls.Add(lblSubTituloEditar);
            this.Controls.Add(btEditarCliente);
            this.Controls.Add(btEditarVeiculoLeve);
            this.Controls.Add(btEditarVeiculoPesado);
        }

        private void btCadastrarCliente(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
        }
        private void btCadastrarLocacao(object sender, EventArgs e)
        {
            CadastrarLocacao cadastrarLocacao = new CadastrarLocacao();
            cadastrarLocacao.Show();
        }
        private void btCadastrarVeiculoLeve(object sender, EventArgs e)
        {
            CadastrarVeiculoLeve cadastrarVeiculoLeve = new CadastrarVeiculoLeve();
            cadastrarVeiculoLeve.Show();
        }
        private void btCadastrarVeiculoPesado(object sender, EventArgs e)
        {
            CadastrarVeiculoPesado cadastrarVeiculoPesado = new CadastrarVeiculoPesado();
            cadastrarVeiculoPesado.Show();
        }
    }
}