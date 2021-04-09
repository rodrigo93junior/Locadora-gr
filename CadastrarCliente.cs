using System;
using System.Windows.Forms;
using System.Drawing;

namespace View {
    public class CadastrarCliente : Form {
        public CadastrarCliente() {
            this.Text = "Cadastro de Cliente";

            Label lblTitulo = new Label();
            lblTitulo.Text = "Bem vindo!";
            lblTitulo.Location = new Point (220,10);
            lblTitulo.Size = new Size(80,40);

            TextBox Nome = new TextBox();
            Nome.Location = new Point (20,50);
            Nome.Size = new Size(300,40);

            TextBox DataNascimento = new TextBox();
            DataNascimento.Location = new Point (20,80);
            DataNascimento.Size = new Size(300,40);

            TextBox Cpf = new TextBox();
            Cpf.Location = new Point (20,130);
            Cpf.Size = new Size(300,40);

            TextBox DiasRetorno = new TextBox();
            DiasRetorno.Location = new Point (20,180);
            DiasRetorno.Size = new Size(300,40);

            Button botaoSalvar = new Button();
            botaoSalvar.Text = "Salvar";
            botaoSalvar.Location = new Point (130,20);
            botaoSalvar.Size = new Size(300,40);
            
            

            this.Size = new Size(540, 300);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(Nome);
            this.Controls.Add(DataNascimento);
            this.Controls.Add(Cpf);
            this.Controls.Add(DiasRetorno);
            this.Controls.Add(botaoSalvar);
        }
    }
}