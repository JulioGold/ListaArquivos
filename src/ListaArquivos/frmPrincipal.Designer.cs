namespace ListaArquivos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCaminho = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnGerarLista = new System.Windows.Forms.Button();
            this.txtFiltroBusca = new System.Windows.Forms.TextBox();
            this.chkSubDiretorios = new System.Windows.Forms.CheckBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaminho
            // 
            this.btnCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaminho.Location = new System.Drawing.Point(488, 9);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(30, 23);
            this.btnCaminho.TabIndex = 1;
            this.btnCaminho.Text = "...";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(12, 12);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(470, 20);
            this.txtCaminho.TabIndex = 0;
            // 
            // txtLista
            // 
            this.txtLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLista.Location = new System.Drawing.Point(12, 67);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLista.Size = new System.Drawing.Size(506, 233);
            this.txtLista.TabIndex = 6;
            this.txtLista.WordWrap = false;
            // 
            // btnGerarLista
            // 
            this.btnGerarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarLista.Location = new System.Drawing.Point(443, 38);
            this.btnGerarLista.Name = "btnGerarLista";
            this.btnGerarLista.Size = new System.Drawing.Size(75, 23);
            this.btnGerarLista.TabIndex = 5;
            this.btnGerarLista.Text = "Gerar lista";
            this.btnGerarLista.UseVisualStyleBackColor = true;
            this.btnGerarLista.Click += new System.EventHandler(this.btnGerarLista_Click);
            // 
            // txtFiltroBusca
            // 
            this.txtFiltroBusca.Location = new System.Drawing.Point(50, 38);
            this.txtFiltroBusca.Name = "txtFiltroBusca";
            this.txtFiltroBusca.Size = new System.Drawing.Size(60, 20);
            this.txtFiltroBusca.TabIndex = 3;
            this.txtFiltroBusca.Text = "*.*";
            // 
            // chkSubDiretorios
            // 
            this.chkSubDiretorios.AutoSize = true;
            this.chkSubDiretorios.Checked = true;
            this.chkSubDiretorios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubDiretorios.Location = new System.Drawing.Point(164, 39);
            this.chkSubDiretorios.Name = "chkSubDiretorios";
            this.chkSubDiretorios.Size = new System.Drawing.Size(105, 17);
            this.chkSubDiretorios.TabIndex = 4;
            this.chkSubDiretorios.Text = "Incluir subpastas";
            this.chkSubDiretorios.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 43);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 312);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.chkSubDiretorios);
            this.Controls.Add(this.txtFiltroBusca);
            this.Controls.Add(this.btnGerarLista);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnCaminho);
            this.Name = "frmPrincipal";
            this.Text = "Lista arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaminho;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnGerarLista;
        private System.Windows.Forms.TextBox txtFiltroBusca;
        private System.Windows.Forms.CheckBox chkSubDiretorios;
        private System.Windows.Forms.Label lblFiltro;
    }
}

