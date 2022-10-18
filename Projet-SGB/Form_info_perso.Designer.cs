namespace Projet_SGB
{
    partial class Form_info_perso
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
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_rue = new System.Windows.Forms.TextBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.textBox_date_embauche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_modif_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(310, 60);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.ReadOnly = true;
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 0;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(310, 107);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.ReadOnly = true;
            this.textBox_prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom.TabIndex = 1;
            // 
            // textBox_rue
            // 
            this.textBox_rue.Location = new System.Drawing.Point(310, 153);
            this.textBox_rue.Name = "textBox_rue";
            this.textBox_rue.ReadOnly = true;
            this.textBox_rue.Size = new System.Drawing.Size(100, 20);
            this.textBox_rue.TabIndex = 2;
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(310, 250);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.ReadOnly = true;
            this.textBox_ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_ville.TabIndex = 3;
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(310, 200);
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.ReadOnly = true;
            this.textBox_cp.Size = new System.Drawing.Size(100, 20);
            this.textBox_cp.TabIndex = 4;
            // 
            // textBox_date_embauche
            // 
            this.textBox_date_embauche.Location = new System.Drawing.Point(310, 302);
            this.textBox_date_embauche.Name = "textBox_date_embauche";
            this.textBox_date_embauche.ReadOnly = true;
            this.textBox_date_embauche.Size = new System.Drawing.Size(100, 20);
            this.textBox_date_embauche.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Code postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date embauche";
            // 
            // button_modif_info
            // 
            this.button_modif_info.Location = new System.Drawing.Point(275, 363);
            this.button_modif_info.Name = "button_modif_info";
            this.button_modif_info.Size = new System.Drawing.Size(135, 47);
            this.button_modif_info.TabIndex = 16;
            this.button_modif_info.Text = "Modifier mes informations";
            this.button_modif_info.UseVisualStyleBackColor = true;
            this.button_modif_info.Click += new System.EventHandler(this.button_modif_info_Click);
            // 
            // Form_info_perso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 645);
            this.Controls.Add(this.button_modif_info);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_date_embauche);
            this.Controls.Add(this.textBox_cp);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.textBox_rue);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Name = "Form_info_perso";
            this.Text = "Form_info_perso";
            this.Load += new System.EventHandler(this.Form_info_perso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_rue;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.TextBox textBox_date_embauche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modif_info;
    }
}