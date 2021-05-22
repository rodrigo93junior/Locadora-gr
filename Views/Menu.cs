using System;
using System.Windows.Forms;
using System.Drawing;


namespace Views
{
    public class Menu : Form
    {
        PictureBox pbImagem;
        public Menu()
        {
            this.Text = "GR - Locadora de Veículos";

            pbImagem = new PictureBox();
            pbImagem.Size = new Size(300, 120);
            pbImagem.Location = new Point(130,3);
            pbImagem.Load("gr.jpg");
            pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            Label lblTitulo = new Label();
            lblTitulo.Text = "Bem vindo!";
            lblTitulo.Location = new Point(220, 110);
            lblTitulo.Size = new Size(80, 50);

            Label lblSubTitulo = new Label();
            lblSubTitulo.Text = "Cadastros:";
            lblSubTitulo.Location = new Point(20, 140);
            lblSubTitulo.Size = new Size(80, 20);

            Button btCadastrarLocacao = new Button();
            btCadastrarLocacao.Text = "Cadastrar Locação";
            btCadastrarLocacao.Location = new Point(20, 180);
            btCadastrarLocacao.Size = new Size(200, 40);
            btCadastrarLocacao.Click += new EventHandler(this.btCadastrarLocacao);

            Button btCadastrarCliente = new Button();
            btCadastrarCliente.Text = "Cadastrar Cliente";
            btCadastrarCliente.Location = new Point(20, 230);
            btCadastrarCliente.Size = new Size(200, 40);
            btCadastrarCliente.Click += new EventHandler(this.btCadastrarCliente);

            Button btCadastrarVeiculoLeve = new Button();
            btCadastrarVeiculoLeve.Text = "Cadastrar Veículo Leve";
            btCadastrarVeiculoLeve.Location = new Point(20, 280);
            btCadastrarVeiculoLeve.Size = new Size(200, 40);
            btCadastrarVeiculoLeve.Click += new EventHandler(this.btCadastrarVeiculoLeve);

            Button btCadastrarVeiculoPesado = new Button();
            btCadastrarVeiculoPesado.Text = "Cadastrar Veículo Pesado";
            btCadastrarVeiculoPesado.Location = new Point(20, 330);
            btCadastrarVeiculoPesado.Size = new Size(200, 40);
            btCadastrarVeiculoPesado.Click += new EventHandler(this.btCadastrarVeiculoPesado);

            Label lblSubTituloVisualizacao = new Label();
            lblSubTituloVisualizacao.Text = "Visualização:";
            lblSubTituloVisualizacao.Location = new Point(300, 140);
            lblSubTituloVisualizacao.Size = new Size(80, 20);

            Button btListarCliente = new Button();
            btListarCliente.Text = "Buscar Cliente";
            btListarCliente.Location = new Point(300, 180);
            btListarCliente.Size = new Size(200, 40);
            btListarCliente.Click += new EventHandler(this.btListarCliente);

            Button btListarVeiculoLeve = new Button();
            btListarVeiculoLeve.Text = "Buscar Veículo Leve";
            btListarVeiculoLeve.Location = new Point(300, 230);
            btListarVeiculoLeve.Size = new Size(200, 40);
            btListarVeiculoLeve.Click += new EventHandler(this.btListarVeiculoLeve);

            Button btListarVeiculoPesado = new Button();
            btListarVeiculoPesado.Text = "Buscar Veículo Pesado";
            btListarVeiculoPesado.Location = new Point(300, 280);
            btListarVeiculoPesado.Size = new Size(200, 40);
            btListarVeiculoPesado.Click += new EventHandler(this.btListarVeiculoPesado);

            Label lblSubTituloEditar = new Label();
            lblSubTituloEditar.Text = "Editar:";
            lblSubTituloEditar.Location = new Point(20, 390);
            lblSubTituloEditar.Size = new Size(80, 20);

            Button btEditarCliente = new Button();
            btEditarCliente.Text = "Editar Cliente";
            btEditarCliente.Location = new Point(20, 420);
            btEditarCliente.Size = new Size(200, 40);

            Button btEditarVeiculoLeve = new Button();
            btEditarVeiculoLeve.Text = "Editar Veículo Leve";
            btEditarVeiculoLeve.Location = new Point(20, 470);
            btEditarVeiculoLeve.Size = new Size(200, 40);

            Button btEditarVeiculoPesado = new Button();
            btEditarVeiculoPesado.Text = "Editar Veículo Pesado";
            btEditarVeiculoPesado.Location = new Point(20, 520);
            btEditarVeiculoPesado.Size = new Size(200, 40);


            this.Size = new Size(600, 700);
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
    
        private void btListarCliente(object sender, EventArgs e)
        {
            ListarCliente listarCliente = new ListarCliente();
            listarCliente.Show();
        }
        private void btListarVeiculoLeve(object sender, EventArgs e)
        {
            ListarVeiculosLeves listarVeiculosLeves = new ListarVeiculosLeves();
            listarVeiculosLeves.Show();
        }
        private void btListarVeiculoPesado(object sender, EventArgs e)
        {
            ListarVeiculosPesados listarVeiculosPesados = new ListarVeiculosPesados();
            listarVeiculosPesados.Show();
        }
    }
}