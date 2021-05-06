using System;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;

namespace View
{
    public class ListarCliente : Form {
        LibTituloLabel lblTitulo;
        LibListView listagem;
        public ListarCliente()
        {
            this.Text = "Lista de Clientes";

            lblTitulo = new LibTituloLabel("Listagem de Cliente", new Point(180, 10), new Size(180, 40));
            
            listagem = new LibListView(new Point (80, 15), new Size (400, 400));

            this.Size = new Size(600, 600);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(listagem);
        }
    }
}