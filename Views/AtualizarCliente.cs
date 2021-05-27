using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Views.Lib;

namespace Views
{
    
    public class AtualizarCliente : Form
    {
        LibTituloLabel lblTitulo;
        LibLabel lblId;
        LibTextBox id;
        LibComboBox combo;
        LibButton btnSalvarCliente;
        LibButton btnCancelar;
    public AtualizarCliente()
        {
            this.Text = "Alterar cadastro de Cliente";

            lblTitulo = new LibTituloLabel("Alterar cadastro de Cliente", new Point(180, 10), new Size(180, 40));
            lblId = new LibLabel("Id:", new Point(20, 30), new Size(120, 15));
            id = new LibTextBox(new Point(20, 50), new Size(300, 40));
            int ConvertId = Convert.ToInt32(id);
             IEnumerable<Model.Cliente> clientes = Model.Cliente.GetCliente(int Id);
            try
            {
               IEnumerable<Model.Cliente> clientes = Controller.Cliente.ListarClientes ();
            LibColuna[] colunas = new LibColuna[] {
                new LibColuna ("ID", HorizontalAlignment.Left),
                new LibColuna ("Nome Completo", HorizontalAlignment.Left),
                new LibColuna ("Data Nascimento", HorizontalAlignment.Left),
                new LibColuna ("CPF", HorizontalAlignment.Left),
                new LibColuna ("Dias Devolção", HorizontalAlignment.Left)
            };
            
            listagemCliente = new LibListView(25, 25, 400, 350, colunas);
            catch (Exception error)
            {
                throw error;
            }

            List<string> listaClientes = new List<string>();
            foreach (Model.Cliente item in clientes)
            {
                listaClientes.Add($"{item.Id} - {item.Nome} - {item.DataNascimento} - {item.Cpf} - {item.DiasRetorno}");
            }
            string[] options = listaClientes.ToArray();

            combo = new LibComboBox(new Point(20, 260), new Size(300, 40));

            btnSalvarCliente = new LibButton("Salvar", new Point(100, 300), new Size(100, 40));
            btnSalvarCliente.Click += new EventHandler(this.botaoSalvarCliente);

            btnCancelar = new LibButton("Cancelar", new Point(200, 300), new Size(100, 40));
            btnCancelar.Click += new EventHandler(this.botaoCancelar);
        
            this.Size = new Size(540, 400);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblId);
            this.Controls.Add(id);
            
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
                string valorCombo = this.combo.Text; 
                int pos = valorCombo.IndexOf("-"); 

                string id = valorCombo.Substring(0, pos - 1);
                CadastrarCliente cadastro = new CadastrarCliente(id);
                cadastro.Show();
               
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
                MessageBox.Show("Cliente não cadastrado");
            }
            else
            {
                MessageBox.Show("Opção Invalida!");
            }

            this.Close();
        }
    }
}