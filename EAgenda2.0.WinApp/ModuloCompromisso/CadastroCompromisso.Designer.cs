namespace EAgenda2._0.WinApp.ModuloCompromisso
{
    partial class CadastroCompromisso
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
            this.txt_HorarioInicio = new System.Windows.Forms.TextBox();
            this.txt_HorarioTermino = new System.Windows.Forms.TextBox();
            this.txt_Local = new System.Windows.Forms.TextBox();
            this.txt_Assunto = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(220, 475);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 45);
            this.btn_Cancelar.TabIndex = 27;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(91, 475);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(94, 45);
            this.btn_Gravar.TabIndex = 26;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // txt_HorarioInicio
            // 
            this.txt_HorarioInicio.Location = new System.Drawing.Point(60, 323);
            this.txt_HorarioInicio.Name = "txt_HorarioInicio";
            this.txt_HorarioInicio.Size = new System.Drawing.Size(187, 27);
            this.txt_HorarioInicio.TabIndex = 25;
            // 
            // txt_HorarioTermino
            // 
            this.txt_HorarioTermino.Location = new System.Drawing.Point(60, 387);
            this.txt_HorarioTermino.Name = "txt_HorarioTermino";
            this.txt_HorarioTermino.Size = new System.Drawing.Size(187, 27);
            this.txt_HorarioTermino.TabIndex = 24;
            // 
            // txt_Local
            // 
            this.txt_Local.Location = new System.Drawing.Point(60, 195);
            this.txt_Local.Name = "txt_Local";
            this.txt_Local.Size = new System.Drawing.Size(300, 27);
            this.txt_Local.TabIndex = 22;
            // 
            // txt_Assunto
            // 
            this.txt_Assunto.Location = new System.Drawing.Point(60, 131);
            this.txt_Assunto.Name = "txt_Assunto";
            this.txt_Assunto.Size = new System.Drawing.Size(300, 27);
            this.txt_Assunto.TabIndex = 21;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(60, 67);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(87, 27);
            this.txt_Id.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Horário Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Horário Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Assunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(60, 259);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data:";
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txt_HorarioInicio);
            this.Controls.Add(this.txt_HorarioTermino);
            this.Controls.Add(this.txt_Local);
            this.Controls.Add(this.txt_Assunto);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCompromisso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Compromisso";
            this.Load += new System.EventHandler(this.CadastroCompromisso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox txt_HorarioInicio;
        private System.Windows.Forms.TextBox txt_HorarioTermino;
        private System.Windows.Forms.TextBox txt_Local;
        private System.Windows.Forms.TextBox txt_Assunto;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
    }
}