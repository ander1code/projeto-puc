namespace WinMatriculaApp
{
    partial class FrmMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatricula));
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.gpArquivo = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpMatricula = new System.Windows.Forms.GroupBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdArquivo = new System.Windows.Forms.RadioButton();
            this.rdInforme = new System.Windows.Forms.RadioButton();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.gpArquivo.SuspendLayout();
            this.gpMatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.FileOk += new System.ComponentModel.CancelEventHandler(this.file_FileOk);
            // 
            // gpArquivo
            // 
            this.gpArquivo.Controls.Add(this.txtPath);
            this.gpArquivo.Controls.Add(this.btnOpen);
            this.gpArquivo.Controls.Add(this.label3);
            this.gpArquivo.Location = new System.Drawing.Point(12, 202);
            this.gpArquivo.Name = "gpArquivo";
            this.gpArquivo.Size = new System.Drawing.Size(600, 120);
            this.gpArquivo.TabIndex = 9;
            this.gpArquivo.TabStop = false;
            this.gpArquivo.Text = "Lista em Arquivo";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(15, 68);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(440, 38);
            this.txtPath.TabIndex = 18;
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(458, 68);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 40);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selecionar arquivo";
            // 
            // gpMatricula
            // 
            this.gpMatricula.Controls.Add(this.txtMatricula);
            this.gpMatricula.Controls.Add(this.label2);
            this.gpMatricula.Location = new System.Drawing.Point(12, 67);
            this.gpMatricula.Name = "gpMatricula";
            this.gpMatricula.Size = new System.Drawing.Size(600, 120);
            this.gpMatricula.TabIndex = 13;
            this.gpMatricula.TabStop = false;
            this.gpMatricula.Text = "Matrícula avulsa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(15, 58);
            this.txtMatricula.MaxLength = 4;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(575, 38);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Informe a matrícula";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(470, 328);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 40);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdArquivo
            // 
            this.rdArquivo.AutoSize = true;
            this.rdArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdArquivo.Location = new System.Drawing.Point(470, 32);
            this.rdArquivo.Name = "rdArquivo";
            this.rdArquivo.Size = new System.Drawing.Size(140, 29);
            this.rdArquivo.TabIndex = 14;
            this.rdArquivo.Text = "Em Arquivo";
            this.rdArquivo.UseVisualStyleBackColor = true;
            this.rdArquivo.CheckedChanged += new System.EventHandler(this.rdArquivo_CheckedChanged);
            // 
            // rdInforme
            // 
            this.rdInforme.AutoSize = true;
            this.rdInforme.Checked = true;
            this.rdInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdInforme.Location = new System.Drawing.Point(363, 32);
            this.rdInforme.Name = "rdInforme";
            this.rdInforme.Size = new System.Drawing.Size(92, 29);
            this.rdInforme.TabIndex = 15;
            this.rdInforme.TabStop = true;
            this.rdInforme.Text = "Digitar";
            this.rdInforme.UseVisualStyleBackColor = true;
            this.rdInforme.CheckedChanged += new System.EventHandler(this.rdInforme_CheckedChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(359, 9);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(184, 20);
            this.lblOptions.TabIndex = 16;
            this.lblOptions.Text = "Selecione uma Opção";
            // 
            // btnTestar
            // 
            this.btnTestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestar.Image = ((System.Drawing.Image)(resources.GetObject("btnTestar.Image")));
            this.btnTestar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestar.Location = new System.Drawing.Point(342, 328);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(125, 40);
            this.btnTestar.TabIndex = 17;
            this.btnTestar.Text = "Testar";
            this.btnTestar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 386);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.rdInforme);
            this.Controls.Add(this.rdArquivo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpMatricula);
            this.Controls.Add(this.gpArquivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador de Matrícula";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            this.gpArquivo.ResumeLayout(false);
            this.gpArquivo.PerformLayout();
            this.gpMatricula.ResumeLayout(false);
            this.gpMatricula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog file;
        private System.Windows.Forms.GroupBox gpArquivo;
        private System.Windows.Forms.GroupBox gpMatricula;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdArquivo;
        private System.Windows.Forms.RadioButton rdInforme;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnTestar;
    }
}