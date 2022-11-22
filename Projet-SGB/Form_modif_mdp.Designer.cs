namespace Projet_SGB
{
    partial class Form_modif_mdp
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
            this.textBox_mdp_actuel = new System.Windows.Forms.TextBox();
            this.textBox_conf_nv_mdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nv_mdp = new System.Windows.Forms.TextBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_mdp_actuel
            // 
            this.textBox_mdp_actuel.Location = new System.Drawing.Point(77, 59);
            this.textBox_mdp_actuel.Name = "textBox_mdp_actuel";
            this.textBox_mdp_actuel.Size = new System.Drawing.Size(100, 20);
            this.textBox_mdp_actuel.TabIndex = 0;
            // 
            // textBox_conf_nv_mdp
            // 
            this.textBox_conf_nv_mdp.Location = new System.Drawing.Point(77, 191);
            this.textBox_conf_nv_mdp.Name = "textBox_conf_nv_mdp";
            this.textBox_conf_nv_mdp.Size = new System.Drawing.Size(100, 20);
            this.textBox_conf_nv_mdp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrez votre mot de passe actuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirmation du nouveau mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entrez votre nouveau mot de passe";
            // 
            // textBox_nv_mdp
            // 
            this.textBox_nv_mdp.Location = new System.Drawing.Point(77, 126);
            this.textBox_nv_mdp.Name = "textBox_nv_mdp";
            this.textBox_nv_mdp.Size = new System.Drawing.Size(100, 20);
            this.textBox_nv_mdp.TabIndex = 1;
            this.textBox_nv_mdp.TextChanged += new System.EventHandler(this.textBox_nv_mdp_TextChanged);
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(89, 231);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 6;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // Form_modif_mdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 303);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_conf_nv_mdp);
            this.Controls.Add(this.textBox_nv_mdp);
            this.Controls.Add(this.textBox_mdp_actuel);
            this.Name = "Form_modif_mdp";
            this.Text = "Form_modif_mdp";
            this.Load += new System.EventHandler(this.Form_modif_mdp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mdp_actuel;
        private System.Windows.Forms.TextBox textBox_conf_nv_mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nv_mdp;
        private System.Windows.Forms.Button button_valider;
    }
}