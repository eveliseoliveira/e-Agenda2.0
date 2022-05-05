namespace EAgenda2._0.WinApp
{
    partial class TelaCadastroContatos
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
            this.listContatos = new System.Windows.Forms.ListBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Vizualizar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 20;
            this.listContatos.Location = new System.Drawing.Point(223, 43);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(664, 364);
            this.listContatos.TabIndex = 25;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(28, 239);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(160, 44);
            this.btn_Excluir.TabIndex = 23;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(28, 170);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(160, 44);
            this.btn_Editar.TabIndex = 21;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Vizualizar
            // 
            this.btn_Vizualizar.Location = new System.Drawing.Point(28, 109);
            this.btn_Vizualizar.Name = "btn_Vizualizar";
            this.btn_Vizualizar.Size = new System.Drawing.Size(160, 44);
            this.btn_Vizualizar.TabIndex = 20;
            this.btn_Vizualizar.Text = "Visualizar";
            this.btn_Vizualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(28, 43);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(160, 44);
            this.btn_Inserir.TabIndex = 19;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // TelaCadastroContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 443);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Vizualizar);
            this.Controls.Add(this.btn_Inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroContatos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Vizualizar;
        private System.Windows.Forms.Button btn_Inserir;
    }
}