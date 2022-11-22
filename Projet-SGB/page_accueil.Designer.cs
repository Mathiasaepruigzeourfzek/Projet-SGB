namespace Projet_SGB
{
    partial class page_accueil
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
            this.visualiserVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichePayeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichePayeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nom_user_courant
            // 
            this.textBox_nom_user_courant.Location = new System.Drawing.Point(41, 39);
            this.textBox_nom_user_courant.Name = "textBox_nom_user_courant";
            this.textBox_nom_user_courant.Size = new System.Drawing.Size(189, 20);
            this.textBox_nom_user_courant.TabIndex = 0;
            this.textBox_nom_user_courant.TextChanged += new System.EventHandler(this.textBox_nom_user_courant_TextChanged);
            // 
            // textBox_prenom_user_courant
            // 
            this.textBox_prenom_user_courant.Location = new System.Drawing.Point(41, 90);
            this.textBox_prenom_user_courant.Name = "textBox_prenom_user_courant";
            this.textBox_prenom_user_courant.Size = new System.Drawing.Size(189, 20);
            this.textBox_prenom_user_courant.TabIndex = 1;
            this.textBox_prenom_user_courant.TextChanged += new System.EventHandler(this.textBox_prenom_user_courant_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.mission2ToolStripMenuItem,
            this.mission3ToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.fichePayeToolStripMenuItem1});
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
            this.visualiserVisiteursToolStripMenuItem,
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.consultationToolStripMenuItem.Text = "Mission 1";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // informationsPersonnellesToolStripMenuItem
            // 
            this.informationsPersonnellesToolStripMenuItem.Name = "informationsPersonnellesToolStripMenuItem";
            this.informationsPersonnellesToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.informationsPersonnellesToolStripMenuItem.Text = "Informations personnelles";
            this.informationsPersonnellesToolStripMenuItem.Click += new System.EventHandler(this.informationsPersonnellesToolStripMenuItem_Click);
            // 
            // résponsabilitéToolStripMenuItem
            // 
            this.résponsabilitéToolStripMenuItem.Name = "résponsabilitéToolStripMenuItem";
            this.résponsabilitéToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.résponsabilitéToolStripMenuItem.Text = "Résponsabilité";
            // 
            // modifierVotreMotDePasseToolStripMenuItem
            // 
            this.modifierVotreMotDePasseToolStripMenuItem.Name = "modifierVotreMotDePasseToolStripMenuItem";
            this.modifierVotreMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.modifierVotreMotDePasseToolStripMenuItem.Text = "Modifier votre mot de passe";
            this.modifierVotreMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.modifierVotreMotDePasseToolStripMenuItem_Click);
            // 
            // visualiserVisiteursToolStripMenuItem
            // 
            this.visualiserVisiteursToolStripMenuItem.Name = "visualiserVisiteursToolStripMenuItem";
            this.visualiserVisiteursToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.visualiserVisiteursToolStripMenuItem.Text = "Visualiser visiteurs";
            // 
            // mettreAJourLesInformationsDuSecteurToolStripMenuItem
            // 
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem.Name = "mettreAJourLesInformationsDuSecteurToolStripMenuItem";
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem.Text = "Mettre a jour les informations du secteur";
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem.Click += new System.EventHandler(this.mettreAJourLesInformationsDuSecteurToolStripMenuItem_Click);
            this.mettreAJourLesInformationsDuSecteurToolStripMenuItem.VisibleChanged += new System.EventHandler(this.mettreAJourLesInformationsDuSecteurToolStripMenuItem_VisibleChanged);
            // 
            // mission2ToolStripMenuItem
            // 
            this.mission2ToolStripMenuItem.Name = "mission2ToolStripMenuItem";
            this.mission2ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.mission2ToolStripMenuItem.Text = "Mission2";
            // 
            // mission3ToolStripMenuItem
            // 
            this.mission3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichePayeToolStripMenuItem});
            this.mission3ToolStripMenuItem.Name = "mission3ToolStripMenuItem";
            this.mission3ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.mission3ToolStripMenuItem.Text = "Mission3";
            this.mission3ToolStripMenuItem.Click += new System.EventHandler(this.mission3ToolStripMenuItem_Click);
            // 
            // fichePayeToolStripMenuItem
            // 
            this.fichePayeToolStripMenuItem.Name = "fichePayeToolStripMenuItem";
            this.fichePayeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fichePayeToolStripMenuItem.Text = "Fiche paye";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // fichePayeToolStripMenuItem1
            // 
            this.fichePayeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okToolStripMenuItem});
            this.fichePayeToolStripMenuItem1.Name = "fichePayeToolStripMenuItem1";
            this.fichePayeToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.fichePayeToolStripMenuItem1.Text = "fiche paye";
            // 
            // okToolStripMenuItem
            // 
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.okToolStripMenuItem.Text = "ok";
            // 
            // page_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 648);
            this.Controls.Add(this.textBox_prenom_user_courant);
            this.Controls.Add(this.textBox_nom_user_courant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "page_accueil";
            this.Text = "Page d\'accueil";
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
        private System.Windows.Forms.ToolStripMenuItem visualiserVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mettreAJourLesInformationsDuSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichePayeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichePayeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem;
    }
}