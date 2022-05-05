namespace EAgenda2._0.WinApp
{
    partial class CadastroTarefa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.rb_Alta = new System.Windows.Forms.RadioButton();
            this.rb_Normal = new System.Windows.Forms.RadioButton();
            this.rb_Baixa = new System.Windows.Forms.RadioButton();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(118, 107);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(338, 27);
            this.txt_Titulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prioridade da Tarefa:";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(131, 311);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(94, 45);
            this.btn_Gravar.TabIndex = 6;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(260, 311);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 45);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // rb_Alta
            // 
            this.rb_Alta.AutoSize = true;
            this.rb_Alta.Location = new System.Drawing.Point(145, 239);
            this.rb_Alta.Name = "rb_Alta";
            this.rb_Alta.Size = new System.Drawing.Size(57, 24);
            this.rb_Alta.TabIndex = 10;
            this.rb_Alta.TabStop = true;
            this.rb_Alta.Text = "Alta";
            this.rb_Alta.UseVisualStyleBackColor = true;
            // 
            // rb_Normal
            // 
            this.rb_Normal.AutoSize = true;
            this.rb_Normal.Location = new System.Drawing.Point(208, 239);
            this.rb_Normal.Name = "rb_Normal";
            this.rb_Normal.Size = new System.Drawing.Size(80, 24);
            this.rb_Normal.TabIndex = 11;
            this.rb_Normal.TabStop = true;
            this.rb_Normal.Text = "Normal";
            this.rb_Normal.UseVisualStyleBackColor = true;
            // 
            // rb_Baixa
            // 
            this.rb_Baixa.AutoSize = true;
            this.rb_Baixa.Location = new System.Drawing.Point(294, 239);
            this.rb_Baixa.Name = "rb_Baixa";
            this.rb_Baixa.Size = new System.Drawing.Size(66, 24);
            this.rb_Baixa.TabIndex = 12;
            this.rb_Baixa.TabStop = true;
            this.rb_Baixa.Text = "Baixa";
            this.rb_Baixa.UseVisualStyleBackColor = true;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Enabled = false;
            this.txt_Numero.Location = new System.Drawing.Point(118, 52);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(130, 27);
            this.txt_Numero.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Número:";
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 410);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_Baixa);
            this.Controls.Add(this.rb_Normal);
            this.Controls.Add(this.rb_Alta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.RadioButton rb_Alta;
        private System.Windows.Forms.RadioButton rb_Normal;
        private System.Windows.Forms.RadioButton rb_Baixa;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label3;
    }
}