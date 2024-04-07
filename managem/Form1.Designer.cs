namespace managem
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblpath = new System.Windows.Forms.Label();
            this.Ouvrir_un_nouveau_fichier_PDF = new System.Windows.Forms.Button();
            this.txt_matricules = new System.Windows.Forms.TextBox();
            this.btn_chercher_matricules = new System.Windows.Forms.Button();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(15, 179);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(750, 894);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblpath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpath.Location = new System.Drawing.Point(12, 148);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(44, 17);
            this.lblpath.TabIndex = 1;
            this.lblpath.Text = ".........";
            // 
            // Ouvrir_un_nouveau_fichier_PDF
            // 
            this.Ouvrir_un_nouveau_fichier_PDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Ouvrir_un_nouveau_fichier_PDF.FlatAppearance.BorderSize = 0;
            this.Ouvrir_un_nouveau_fichier_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ouvrir_un_nouveau_fichier_PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ouvrir_un_nouveau_fichier_PDF.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Ouvrir_un_nouveau_fichier_PDF.Location = new System.Drawing.Point(332, 92);
            this.Ouvrir_un_nouveau_fichier_PDF.Name = "Ouvrir_un_nouveau_fichier_PDF";
            this.Ouvrir_un_nouveau_fichier_PDF.Size = new System.Drawing.Size(491, 48);
            this.Ouvrir_un_nouveau_fichier_PDF.TabIndex = 2;
            this.Ouvrir_un_nouveau_fichier_PDF.Text = "Ouvrir un nouveau fichier PDF";
            this.Ouvrir_un_nouveau_fichier_PDF.UseVisualStyleBackColor = false;
            this.Ouvrir_un_nouveau_fichier_PDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_matricules
            // 
            this.txt_matricules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txt_matricules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matricules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricules.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_matricules.Location = new System.Drawing.Point(118, 28);
            this.txt_matricules.Multiline = true;
            this.txt_matricules.Name = "txt_matricules";
            this.txt_matricules.Size = new System.Drawing.Size(1357, 38);
            this.txt_matricules.TabIndex = 4;
            this.txt_matricules.Text = "                                                                                 " +
    "                      Matricules";
            this.txt_matricules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_matricules_MouseClick);
            this.txt_matricules.TextChanged += new System.EventHandler(this.txt_matricules_TextChanged);
            // 
            // btn_chercher_matricules
            // 
            this.btn_chercher_matricules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_chercher_matricules.FlatAppearance.BorderSize = 0;
            this.btn_chercher_matricules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercher_matricules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercher_matricules.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_chercher_matricules.Location = new System.Drawing.Point(979, 92);
            this.btn_chercher_matricules.Name = "btn_chercher_matricules";
            this.btn_chercher_matricules.Size = new System.Drawing.Size(496, 48);
            this.btn_chercher_matricules.TabIndex = 5;
            this.btn_chercher_matricules.Text = "Chercher";
            this.btn_chercher_matricules.UseVisualStyleBackColor = false;
            this.btn_chercher_matricules.Click += new System.EventHandler(this.btn_chercher_matricules_Click);
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(786, 179);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(755, 894);
            this.axAcroPDF2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1942, 3);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 1099);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1942, 3);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1939, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 1096);
            this.panel5.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 1096);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(118, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1357, 1);
            this.panel2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::managem.Properties.Resources.icone4;
            this.button3.Location = new System.Drawing.Point(15, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 72);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::managem.Properties.Resources.Button_Delete_icon;
            this.button1.Location = new System.Drawing.Point(1889, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 51);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.axAcroPDF2);
            this.Controls.Add(this.btn_chercher_matricules);
            this.Controls.Add(this.txt_matricules);
            this.Controls.Add(this.Ouvrir_un_nouveau_fichier_PDF);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.axAcroPDF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Button Ouvrir_un_nouveau_fichier_PDF;
        private System.Windows.Forms.TextBox txt_matricules;
        private System.Windows.Forms.Button btn_chercher_matricules;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
    }
}

