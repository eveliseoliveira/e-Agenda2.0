namespace EAgenda2._0.WinApp
{
    partial class CadastroItensTarefa
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TituloItem = new System.Windows.Forms.TextBox();
            this.list_ItensTarefa = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TituloTarefa = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(293, 401);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 45);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(164, 401);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(94, 45);
            this.btn_Gravar.TabIndex = 8;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Título:";
            // 
            // txt_TituloItem
            // 
            this.txt_TituloItem.Location = new System.Drawing.Point(115, 79);
            this.txt_TituloItem.Name = "txt_TituloItem";
            this.txt_TituloItem.Size = new System.Drawing.Size(287, 27);
            this.txt_TituloItem.TabIndex = 11;
            // 
            // list_ItensTarefa
            // 
            this.list_ItensTarefa.FormattingEnabled = true;
            this.list_ItensTarefa.ItemHeight = 20;
            this.list_ItensTarefa.Location = new System.Drawing.Point(52, 146);
            this.list_ItensTarefa.Name = "list_ItensTarefa";
            this.list_ItensTarefa.Size = new System.Drawing.Size(457, 224);
            this.list_ItensTarefa.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tarefa:";
            // 
            // label_TituloTarefa
            // 
            this.label_TituloTarefa.AutoSize = true;
            this.label_TituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TituloTarefa.Location = new System.Drawing.Point(115, 30);
            this.label_TituloTarefa.Name = "label_TituloTarefa";
            this.label_TituloTarefa.Size = new System.Drawing.Size(110, 20);
            this.label_TituloTarefa.TabIndex = 15;
            this.label_TituloTarefa.Text = "[Título Tarefa]";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(415, 77);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(94, 29);
            this.btn_Adicionar.TabIndex = 16;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click_1);
            // 
            // CadastroItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 483);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.label_TituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_ItensTarefa);
            this.Controls.Add(this.txt_TituloItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItensTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens da Tarefa";
            this.Load += new System.EventHandler(this.CadastroItensTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TituloItem;
        private System.Windows.Forms.ListBox list_ItensTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_TituloTarefa;
        private System.Windows.Forms.Button btn_Adicionar;
    }
}