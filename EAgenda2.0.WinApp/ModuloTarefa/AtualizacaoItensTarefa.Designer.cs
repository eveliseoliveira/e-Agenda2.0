namespace EAgenda2._0.WinApp
{
    partial class AtualizacaoItensTarefa
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
            this.label_TituloTarefa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_ItensTarefa = new System.Windows.Forms.CheckedListBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_TituloTarefa
            // 
            this.label_TituloTarefa.AutoSize = true;
            this.label_TituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TituloTarefa.Location = new System.Drawing.Point(113, 36);
            this.label_TituloTarefa.Name = "label_TituloTarefa";
            this.label_TituloTarefa.Size = new System.Drawing.Size(110, 20);
            this.label_TituloTarefa.TabIndex = 17;
            this.label_TituloTarefa.Text = "[Título Tarefa]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarefa:";
            // 
            // list_ItensTarefa
            // 
            this.list_ItensTarefa.CheckOnClick = true;
            this.list_ItensTarefa.FormattingEnabled = true;
            this.list_ItensTarefa.Location = new System.Drawing.Point(50, 88);
            this.list_ItensTarefa.Name = "list_ItensTarefa";
            this.list_ItensTarefa.Size = new System.Drawing.Size(368, 224);
            this.list_ItensTarefa.TabIndex = 18;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(242, 335);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 45);
            this.btn_Cancelar.TabIndex = 20;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(113, 335);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(94, 45);
            this.btn_Gravar.TabIndex = 19;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // AtualizacaoItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 405);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.list_ItensTarefa);
            this.Controls.Add(this.label_TituloTarefa);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtualizacaoItensTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização dos Itens da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TituloTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox list_ItensTarefa;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
    }
}