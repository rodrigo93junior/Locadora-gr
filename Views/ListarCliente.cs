using System;
using System.Windows.Forms;
using System.Drawing;
//using View.Lib;

namespace Views
{
    public class ListarCliente : Form
    {

        public ListarCliente()
        {
            this.Text = "Lista de Clientes";

            ListView listagemCliente1 = new ListView();
            listagemCliente1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            listagemCliente1.View = View.Details;

            ListViewItem nome = new ListViewItem("Roberto Silva");
            nome.SubItems.Add("20/02/1989");
            nome.SubItems.Add("000.000.000-00");
            nome.SubItems.Add("2");
            ListViewItem dataNascimento = new ListViewItem("Data de nascimento", 0);
            dataNascimento.SubItems.Add("20/02/1989");
            dataNascimento.SubItems.Add("06/12/1991");
            dataNascimento.SubItems.Add("18/03/2000");
            ListViewItem cpf = new ListViewItem("CPF");
            dataNascimento.SubItems.Add("000.000.000-00");
            dataNascimento.SubItems.Add("000.000.000-00");
            dataNascimento.SubItems.Add("000.000.000-00");
            ListViewItem diasDevolucao = new ListViewItem("Dias para Devolução");
            diasDevolucao.SubItems.Add("2");
            diasDevolucao.SubItems.Add("12");
            diasDevolucao.SubItems.Add("30");

            listagemCliente1.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listagemCliente1.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listagemCliente1.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listagemCliente1.Columns.Add("Dias para Retorno", -2, HorizontalAlignment.Left);

            listagemCliente1.Items.AddRange(new ListViewItem[] { nome, dataNascimento, cpf, diasDevolucao });

            this.Controls.Add(listagemCliente1);

            this.Size = new Size(600, 600);

        }
    }
}