using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            this.Text = "Cadastro de Cliente";

            Label lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Novo Cliente";
            lblTitulo.Location = new Point(180, 10);
            lblTitulo.Size = new Size(180, 40);

            Label lblNome = new Label();
            lblNome.Text = "Nome Completo:";
            lblNome.Location = new Point(20, 30);
            lblNome.Size = new Size(120, 15);

            TextBox Nome = new TextBox();
            Nome.Location = new Point(20, 50);
            Nome.Size = new Size(300, 40);

            Label lblDataNascimento = new Label();
            lblDataNascimento.Text = "Data de Nascimento:";
            lblDataNascimento.Location = new Point(20, 80);
            lblDataNascimento.Size = new Size(120, 15);

            TextBox DataNascimento = new TextBox();
            DataNascimento.Location = new Point(20, 100);
            DataNascimento.Size = new Size(300, 40);

            Label lblCpf = new Label();
            lblCpf.Text = "CPF:";
            lblCpf.Location = new Point(20, 130);
            lblCpf.Size = new Size(120, 15);

            TextBox Cpf = new TextBox();
            Cpf.Location = new Point(20, 150);
            Cpf.Size = new Size(300, 40);

            Label lblDiasRetorno = new Label();
            lblDiasRetorno.Text = "Dias para Retorno:";
            lblDiasRetorno.Location = new Point(20, 180);
            lblDiasRetorno.Size = new Size(120, 15);

            TextBox DiasRetorno = new TextBox();
            DiasRetorno.Location = new Point(20, 200);
            DiasRetorno.Size = new Size(300, 40);

            Button btSalvarCliente = new Button();
            btSalvarCliente.Text = "Salvar";
            btSalvarCliente.Location = new Point(150, 250);
            btSalvarCliente.Size = new Size(200, 40);
            btSalvarCliente.Click += new EventHandler(this.btSalvarCliente);


            this.Size = new Size(540, 400);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblNome);
            this.Controls.Add(Nome);
            this.Controls.Add(lblDataNascimento);
            this.Controls.Add(DataNascimento);
            this.Controls.Add(Cpf);
            this.Controls.Add(lblCpf);
            this.Controls.Add(lblDiasRetorno);
            this.Controls.Add(DiasRetorno);
            this.Controls.Add(btSalvarCliente);
        }

        private void btSalvarCliente(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}