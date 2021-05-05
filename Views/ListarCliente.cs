using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class ListarCliente : Form {
        LibTituloLabel lblTitulo;
        LibListView listagem;
        public ListarCliente()
        {
            this.Text = "Lista de Clientes";

            lblTitulo = new LibTituloLabel("Listagem de Cliente", new Point(180, 10), new Size(180, 40));
            
            listagem = new LibListView();
            listagem.Location = new Point (80, 15);
            listagem.Size = new Seze (400, 400);

            this.Size = new Size(600, 600);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(listagem);
        }
    }
}