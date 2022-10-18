namespace Projet_SGB
{
    partial class Mission1
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
            this.textBox_nom_user_courant = new System.Windows.Forms.TextBox();
            this.textBox_prenom_user_courant = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsPersonnellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résponsabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierVotreMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDesBudjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nom_user_courant
            // 
            this.textBox_nom_user_courant.Location = new System.Drawing.Point(41, 39);
            this.textBox_nom_user_courant.Name = "textBox_nom_user_courant";
            this.textBox_nom_user_courant.Size = new System.Drawing.Size(189, 20);
            this.textBox_nom_user_courant.TabIndex = 0;
            // 
            // textBox_prenom_user_courant
            // 
            this.textBox_prenom_user_courant.Location = new System.Drawing.Point(41, 90);
            this.textBox_prenom_user_courant.Name = "textBox_prenom_user_courant";
            this.textBox_prenom_user_courant.Size = new System.Drawing.Size(189, 20);
            this.textBox_prenom_user_courant.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1397, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsPersonnellesToolStripMenuItem,
            this.résponsabilitéToolStripMenuItem,
            this.modifierVotreMotDePasseToolStripMenuItem,
            this.historiqueDesBudjetsToolStripMenuItem,
            this.visualiserVisiteursToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // informationsPersonnellesToolStripMenuItem
            // 
            this.informationsPersonnellesToolStripMenuItem.Name = "informationsPersonnellesToolStripMenuItem";
            this.informationsPersonnellesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.informationsPersonnellesToolStripMenuItem.Text = "Informations personnelles";
            this.informationsPersonnellesToolStripMenuItem.Click += new System.EventHandler(this.informationsPersonnellesToolStripMenuItem_Click);
            // 
            // résponsabilitéToolStripMenuItem
            // 
            this.résponsabilitéToolStripMenuItem.Name = "résponsabilitéToolStripMenuItem";
            this.résponsabilitéToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.résponsabilitéToolStripMenuItem.Text = "Résponsabilité";
            // 
            // modifierVotreMotDePasseToolStripMenuItem
            // 
            this.modifierVotreMotDePasseToolStripMenuItem.Name = "modifierVotreMotDePasseToolStripMenuItem";
            this.modifierVotreMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.modifierVotreMotDePasseToolStripMenuItem.Text = "Modifier votre mot de passe";
            // 
            // historiqueDesBudjetsToolStripMenuItem
            // 
            this.historiqueDesBudjetsToolStripMenuItem.Name = "historiqueDesBudjetsToolStripMenuItem";
            this.historiqueDesBudjetsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.historiqueDesBudjetsToolStripMenuItem.Text = "Historique des budgets";
            this.historiqueDesBudjetsToolStripMenuItem.Click += new System.EventHandler(this.historiqueDesBudjetsToolStripMenuItem_Click);
            // 
            // visualiserVisiteursToolStripMenuItem
            // 
            this.visualiserVisiteursToolStripMenuItem.Name = "visualiserVisiteursToolStripMenuItem";
            this.visualiserVisiteursToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.visualiserVisiteursToolStripMenuItem.Text = "Visualiser visiteurs";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // Mission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 648);
            this.Controls.Add(this.textBox_prenom_user_courant);
            this.Controls.Add(this.textBox_nom_user_courant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mission1";
            this.Text = "Mission1";
            this.Load += new System.EventHandler(this.Mission1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nom_user_courant;
        private System.Windows.Forms.TextBox textBox_prenom_user_courant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsPersonnellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résponsabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierVotreMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDesBudjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
    }
}