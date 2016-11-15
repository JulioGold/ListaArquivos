using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ListaArquivos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            MenuItem mnuItmAltMenuTest;
            mnuItmAltMenuTest = new MenuItem();
            mnuItmAltMenuTest.Text = "Abrir pasta do arquivo";
            mnuItmAltMenuTest.Click += new System.EventHandler(this.AbrePastaSelecionada_Click);
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add(mnuItmAltMenuTest);
            txtLista.ContextMenu = cm;
        }

        private void AbrePastaSelecionada_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtLista.SelectedText))
            {
                Process.Start(txtLista.SelectedText);
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCaminho.Text = fbd.SelectedPath;
            }
        }

        private void btnGerarLista_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCaminho.Text))
            {
                //Limpa a lista
                txtLista.Text = String.Empty;

                StringBuilder sb = new StringBuilder();

                string[] arquivos = Directory.GetFiles(txtCaminho.Text, txtFiltroBusca.Text, (chkSubDiretorios.Checked) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                foreach (string item in arquivos)
                {
                    sb.Append(item + "\r\n");
                }

                txtLista.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("O caminho escolhido não existe.");
            }
        }
    }
}
