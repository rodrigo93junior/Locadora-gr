using System;
using System.Windows.Forms;
using System.Drawing;
using Views.Lib;

namespace Views
{
    public class ListarCliente : Form
    {
        ListView listagemCliente;
        LibTituloLabel lblTitulo;
        LibLabel lblNome;
        LibTextBox nome;
        LibLabel lblIdCliente;
        LibTextBox idCliente;
        LibLabel lblOu;
        LibButton btnOk;
        public ListarCliente()
        {
            this.Text = "Localizar de Cliente";

            lblTitulo = new LibTituloLabel("Buscar Cliente Cadastrado", new Point(180, 10), new Size(180, 40));

            lblIdCliente = new LibLabel("ID do Cliente:", new Point(20, 30), new Size(100, 15));

            idCliente = new LibTextBox(new Point(20, 50), new Size(100, 40));

            lblOu = new LibLabel("Ou", new Point(20, 80), new Size(100, 15));

            lblNome = new LibLabel("Nome do Cliente:", new Point(20, 110), new Size(300, 15));

            nome = new LibTextBox(new Point(20, 140), new Size(300, 40));
            
            listagemCliente = new ListView();
            listagemCliente.Bounds = new Rectangle(new Point(10, 200), new Size(562, 300));
            listagemCliente.View = View.Details;

            ListViewItem cliente1 = new ListViewItem("000001");
            cliente1.SubItems.Add("Roberto Silva");
            cliente1.SubItems.Add("20/02/1989");
            cliente1.SubItems.Add("547.689.030-22");
            cliente1.SubItems.Add("2");

            ListViewItem cliente2 = new ListViewItem("000002");
            cliente2.SubItems.Add("José da Silva");
            cliente2.SubItems.Add("15/12/1979");
            cliente2.SubItems.Add("002.747.032-10");
            cliente2.SubItems.Add("8");

            ListViewItem cliente3 = new ListViewItem("000003");
            cliente3.SubItems.Add("Graziela Nunes");
            cliente3.SubItems.Add("05/07/1990");
            cliente3.SubItems.Add("032.099.325-10");
            cliente3.SubItems.Add("15");
            
            listagemCliente.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listagemCliente.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listagemCliente.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listagemCliente.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listagemCliente.Columns.Add("Dias para Retorno", -2, HorizontalAlignment.Left);

            listagemCliente.Items.AddRange(new ListViewItem[] { cliente1, cliente2, cliente3 });

            btnOk = new LibButton("OK", new Point(250, 550), new Size(100, 40));
            btnOk.Click += new EventHandler(this.botaoOk);

            this.Controls.Add(listagemCliente);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblNome);
            this.Controls.Add(nome);
            this.Controls.Add(lblIdCliente);
            this.Controls.Add(idCliente);
            this.Controls.Add(lblOu);
            this.Controls.Add(btnOk);

            this.Size = new Size(600, 680);
        }
        private void botaoOk(object sender, EventArgs e)
        {        
            this.Close();
        }
    }
}