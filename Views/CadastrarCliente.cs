using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class CadastrarCliente : Form
    {
        Label lblTitulo;
        Label lblNome;
        TextBox nome;
        Label lblDataNascimento;
        TextBox dataNascimento;
        Label lblCpf;
        TextBox cpf;
        Label lblDiasRetorno;
        ComboBox diasRetorno;
        Button btnSalvarCliente;
        GroupBox genero;
        RadioButton generoFeminino;
        RadioButton generoMasculino;
        public CadastrarCliente()
        {
            this.Text = "Cadastro de Cliente";

            lblTitulo = new Label();
            lblTitulo.Text = "Cadastro de Novo Cliente";
            lblTitulo.Location = new Point(180, 10);
            lblTitulo.Size = new Size(180, 40);

            lblNome = new Label();
            lblNome.Text = "Nome Completo:";
            lblNome.Location = new Point(20, 30);
            lblNome.Size = new Size(120, 15);

            nome = new TextBox();
            nome.Location = new Point(20, 50);
            nome.Size = new Size(300, 40);

            lblDataNascimento = new Label();
            lblDataNascimento.Text = "Data de Nascimento:";
            lblDataNascimento.Location = new Point(20, 80);
            lblDataNascimento.Size = new Size(120, 15);

            dataNascimento = new TextBox();
            dataNascimento.Location = new Point(20, 100);
            dataNascimento.Size = new Size(300, 40);

            lblCpf = new Label();
            lblCpf.Text = "CPF:";
            lblCpf.Location = new Point(20, 130);
            lblCpf.Size = new Size(120, 15);

            cpf = new TextBox();
            cpf.Location = new Point(20, 150);
            cpf.Size = new Size(300, 40);

            genero = new GroupBox();
            genero.Text = "Genero";
            genero.Location = new Point(20, 180);
            genero.Size = new Size(300, 50);

            generoFeminino = new RadioButton();
            generoFeminino.Text = "Feminino";
            generoFeminino.Location = new Point(2, 20);
            generoFeminino.Size = new Size(100, 20);

            generoMasculino = new RadioButton();
            generoMasculino.Text = "Maculino";
            generoMasculino.Location = new Point(120, 20);
            generoMasculino.Size = new Size(100, 20);

            genero.Controls.Add(generoFeminino);
            genero.Controls.Add(generoMasculino);

            lblDiasRetorno = new Label();
            lblDiasRetorno.Text = "Dias para Retorno:";
            lblDiasRetorno.Location = new Point(20, 240);
            lblDiasRetorno.Size = new Size(120, 15);

            diasRetorno = new ComboBox();
            diasRetorno.Location = new Point(20, 260);
            diasRetorno.Size = new Size(300, 40);
            diasRetorno.Items.AddRange(new String[] { "1 dia", "5 dias", "10 dias", "15 dias" });

            btnSalvarCliente = new Button();
            btnSalvarCliente.Text = "Salvar";
            btnSalvarCliente.Location = new Point(120, 300);
            btnSalvarCliente.Size = new Size(200, 40);
            btnSalvarCliente.Click += new EventHandler(this.botaoSalvarCliente);


            this.Size = new Size(540, 400);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblNome);
            this.Controls.Add(nome);
            this.Controls.Add(lblDataNascimento);
            this.Controls.Add(dataNascimento);
            this.Controls.Add(cpf);
            this.Controls.Add(lblCpf);
            this.Controls.Add(genero);
            this.Controls.Add(lblDiasRetorno);
            this.Controls.Add(diasRetorno);
            this.Controls.Add(btnSalvarCliente);
        }

        private void botaoSalvarCliente(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}