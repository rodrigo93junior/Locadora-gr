using System;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;
using View.LbComboBox;
/*
 0         1         2         3         4         5         6         7         8         9
  0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
  +-----------------------------------------------------------------------------------------+
00|                                                                                         |
01|                                                                                         |
02|                                                                                         |
03|                                                                                         |
04|                                                                                         |
05|                                                                                         |
06|                                                                                         |
07|                                                                                         |
08|                                                                                         |
09|                                                                                         |
10|                                                                                         |
11|                                                                                         |
12|                                                                                         |
13|                                                                                         |
14|                                                                                         |
15|                                                                                         |
16|                                                                                         |
17|                                                                                         |
18|                                                                                         |
19|                                                                                         |
20|                                                                                         |
  +-----------------------------------------------------------------------------------------+
*/
namespace View
{
    public class CadastrarCliente : Form
    {
        LibTituloLabel lblTitulo;
        LibLabel lblNome;
        LibTextBox nome;
        LibLabel lblDataNascimento;
        LibTextBox dataNascimento;
        LibLabel lblCpf;
        LibTextBox cpf;
        LibLabel lblDiasRetorno;
        LbComboBox diasRetorno;
        GroupBox genero;
        RadioButton generoFeminino;
        RadioButton generoMasculino;
        LibButton btnSalvarCliente;
        LibButton btnCancelar;
        public CadastrarCliente()
        {
            this.Text = "Cadastro de Cliente";

            lblTitulo = new LibTituloLabel("Cadastro de Novo Cliente", new Point (180, 10), new Size (180, 40));

            lblNome = new LibLabel("Nome Completo:", new Point(20, 30), new Size(120, 15));

            nome = new LibTextBox(new Point(20, 50), new Size(300, 40));

            lblDataNascimento = new LibLabel("Data de Nascimento:", new Point(20, 80), new Size(120, 15));

            dataNascimento = new LibTextBox(new Point(20, 100), new Size(300, 40));

            lblCpf = new LibLabel("CPF:", new Point(20, 130), new Size(120, 15));

            cpf = new LibTextBox(new Point(20, 150), new Size(300, 40));

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

            lblDiasRetorno = new LibLabel("Dias para Retorno:", new Point(20, 240), new Size(120, 15));

            diasRetorno = new LibComboBox(new Point(20, 260), new Size(300, 40));
            diasRetorno.Items.AddRange(new String[] { "1 dia", "5 dias", "10 dias", "15 dias" });

            btnSalvarCliente = new LibButton("Salvar", new Point(100, 300), new Size(100, 40));
            btnSalvarCliente.Click += new EventHandler(this.botaoSalvarCliente);

            btnCancelar = new LibButton("Cancelar", new Point(200, 300), new Size(100, 40));
            btnCancelar.Click += new EventHandler(this.botaoCancelar);


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
            this.Controls.Add(btnCancelar);
        }

        private void botaoSalvarCliente(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente cadastrar o cliente?",
                "Confirmar Cadastro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Usuário Cadastrado!");
            }
            else if (resultado == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Usuário não cadastrado");
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