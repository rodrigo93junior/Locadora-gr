using System;
using System.Windows.Forms;
using System.Drawing;
using Views.Lib;
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
namespace Views
{
    public class CadastrarLocacao : Form
    {
        LibTituloLabel lblTitulo;
        LibLabel lblNome;
        LibTextBox nome;
        LibLabel lblDataLocacao;
        LibTextBox dataLocacao;
        LibGroupBox tipo;
        LibRadioButton veiculoLeve;
        LibRadioButton veiculoPesado;
        LibLabel lblModelosVeiculos;
        LibComboBox modelosVeiculos;
        Calendario monthCalendar1;
        LibButton btnSalvarCliente;
        LibButton btnCancelar;
        public CadastrarLocacao()
        {
            this.Text = "Cadastrar Locação";

            lblTitulo = new LibTituloLabel("Cadastro de Nova Locação", new Point(180, 10), new Size(180, 40));

            lblNome = new LibLabel("Nome do Cliente:", new Point(20, 30), new Size(120, 15));

            nome = new LibTextBox(new Point(20, 50), new Size(300, 40));

            lblDataLocacao = new LibLabel("Data de Locação:", new Point(20, 80), new Size(120, 15));

            dataLocacao = new LibTextBox(new Point(20, 100), new Size(300, 40));

            tipo = new LibGroupBox("Tipo", new Point(20, 150), new Size(300, 50));

            veiculoLeve = new LibRadioButton("Veículo Leve", new Point(2, 20), new Size(110, 20));

            veiculoPesado = new LibRadioButton("Veículo Pesado", new Point(120, 20), new Size(110, 20));

            tipo.Controls.Add(veiculoLeve);
            tipo.Controls.Add(veiculoPesado);

            monthCalendar1 = new Calendario(new Point (370, 30));

            lblModelosVeiculos = new LibLabel("Modelos de Veículos:", new Point(20, 240), new Size(120, 15));

            modelosVeiculos = new LibComboBox(new Point(20, 260), new Size(300, 40));
            modelosVeiculos.Items.AddRange(new String[] { "Modelo 1", "Modelo 2", "Modelo 3", "Modelo 4" });

            btnSalvarCliente = new LibButton("Salvar", new Point(100, 300), new Size(100, 40));
            btnSalvarCliente.Click += new EventHandler(this.botaoSalvarCliente);

            btnCancelar = new LibButton("Cancelar", new Point(200, 300), new Size(100, 40));
            btnCancelar.Click += new EventHandler(this.botaoCancelar);


            this.Size = new Size(700, 400);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblNome);
            this.Controls.Add(nome);
            this.Controls.Add(lblDataLocacao);
            this.Controls.Add(dataLocacao);
            this.Controls.Add(tipo);
            this.Controls.Add(monthCalendar1);
            this.Controls.Add(btnSalvarCliente);
            this.Controls.Add(btnCancelar);
        }

        private void botaoSalvarCliente(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente cadastrar a locação?",
                "Confirmar Locação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Locação Cadastrada!");
            }
            else if (resultado == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Locação não cadastrada");
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
                MessageBox.Show("Locação não cadastrada");
            }
            else
            {
                MessageBox.Show("Opção Invalida!");
            }

            this.Close();
        }
    }
}