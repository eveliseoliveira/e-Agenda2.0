namespace EAgenda2._0.WinApp
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tarefas = new System.Windows.Forms.Button();
            this.btn_Contatos = new System.Windows.Forms.Button();
            this.btn_Compromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "e-Agenda 2.0";
            // 
            // btn_Tarefas
            // 
            this.btn_Tarefas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Tarefas.Location = new System.Drawing.Point(37, 120);
            this.btn_Tarefas.Name = "btn_Tarefas";
            this.btn_Tarefas.Size = new System.Drawing.Size(145, 44);
            this.btn_Tarefas.TabIndex = 1;
            this.btn_Tarefas.Text = "Tarefas";
            this.btn_Tarefas.UseVisualStyleBackColor = true;
            this.btn_Tarefas.Click += new System.EventHandler(this.btn_Tarefas_Click);
            // 
            // btn_Contatos
            // 
            this.btn_Contatos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Contatos.Location = new System.Drawing.Point(206, 120);
            this.btn_Contatos.Name = "btn_Contatos";
            this.btn_Contatos.Size = new System.Drawing.Size(145, 44);
            this.btn_Contatos.TabIndex = 2;
            this.btn_Contatos.Text = "Contatos";
            this.btn_Contatos.UseVisualStyleBackColor = true;
            this.btn_Contatos.Click += new System.EventHandler(this.btn_Contatos_Click);
            // 
            // btn_Compromissos
            // 
            this.btn_Compromissos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Compromissos.Location = new System.Drawing.Point(378, 120);
            this.btn_Compromissos.Name = "btn_Compromissos";
            this.btn_Compromissos.Size = new System.Drawing.Size(145, 44);
            this.btn_Compromissos.TabIndex = 3;
            this.btn_Compromissos.Text = "Compromissos";
            this.btn_Compromissos.UseVisualStyleBackColor = true;
            this.btn_Compromissos.Click += new System.EventHandler(this.btn_Compromissos_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 222);
            this.Controls.Add(this.btn_Compromissos);
            this.Controls.Add(this.btn_Contatos);
            this.Controls.Add(this.btn_Tarefas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tarefas;
        private System.Windows.Forms.Button btn_Contatos;
        private System.Windows.Forms.Button btn_Compromissos;
    }
}
