using System;
using System.Windows.Forms;
using System.Drawing;

namespace View {
    public class Menu : Form {
        public Menu() {
            this.Text = "GR - Locadora de Veículos";

            Label lblTitulo = new Label();
            lblTitulo.Text = "Bem vindo!";
            lblTitulo.Location = new Point (220,10);
            lblTitulo.Size = new Size(80,40);

            Label lblSubTitulo = new Label();
            lblSubTitulo.Text = "Cadastros:";
            lblSubTitulo.Location = new Point (20,50);
            lblSubTitulo.Size = new Size(80,20);

            Button btCadastrarCliente = new Button();
            btCadastrarCliente.Text = "Cadastrar Cliente";
            btCadastrarCliente.Location = new Point (20,80);
            btCadastrarCliente.Size = new Size(200,40);
            btCadastrarCliente.Click += new EventHandler(this.btCadastrarCliente);

            Button btCadastrarVeiculoLeve = new Button();
            btCadastrarVeiculoLeve.Text = "Cadastrar Veículo Leve";
            btCadastrarVeiculoLeve.Location = new Point (20,130);
            btCadastrarVeiculoLeve.Size = new Size(200,40);

            Button btCadastrarVeiculoPesado = new Button();
            btCadastrarVeiculoPesado.Text = "Cadastrar Veículo Pesado";
            btCadastrarVeiculoPesado.Location = new Point (20,180);
            btCadastrarVeiculoPesado.Size = new Size(200,40);
            
            Label lblSubTituloVisualizacao = new Label();
            lblSubTituloVisualizacao.Text = "Visualização:";
            lblSubTituloVisualizacao.Location = new Point (300,50);
            lblSubTituloVisualizacao.Size = new Size(80,20);

            Button btListarCliente = new Button();
            btListarCliente.Text = "Listar Cliente";
            btListarCliente.Location = new Point (300,80);
            btListarCliente.Size = new Size(200,40);

            Button btListarVeiculoLeve = new Button();
            btListarVeiculoLeve.Text = "Listar Veículo Leve";
            btListarVeiculoLeve.Location = new Point (300,130);
            btListarVeiculoLeve.Size = new Size(200,40);

            Button btListarVeiculoPesado = new Button();
            btListarVeiculoPesado.Text = "Listar Veículo Pesado";
            btListarVeiculoPesado.Location = new Point (300,180);
            btListarVeiculoPesado.Size = new Size(200,40);
            

            this.Size = new Size(540, 300);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblSubTitulo);
            this.Controls.Add(btCadastrarCliente);
            this.Controls.Add(btCadastrarVeiculoLeve);
            this.Controls.Add(btCadastrarVeiculoPesado);

            this.Controls.Add(lblSubTituloVisualizacao);
            this.Controls.Add(btListarCliente);
            this.Controls.Add(btListarVeiculoLeve);
            this.Controls.Add(btListarVeiculoPesado);
        }

        private void btCadastrarCliente(object sender, EventArgs e){
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
        }
    }
}