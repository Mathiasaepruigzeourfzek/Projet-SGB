namespace Projet_SGB
{
    partial class Mission2
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
            this.components = new System.ComponentModel.Container();
            this.test = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.médecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motifRDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gSBOKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_OKDataSet = new Projet_SGB.GSB_OKDataSet();
            this.compteRenduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteRendu = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSBOKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_OKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompteRendu)).BeginInit();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(347, 150);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 13);
            this.test.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médecinToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.motifRDVToolStripMenuItem,
            this.compteRenduToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.médecinToolStripMenuItem.Text = "Médecin";
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            this.médicamentsToolStripMenuItem.Click += new System.EventHandler(this.médicamentsToolStripMenuItem_Click);
            // 
            // motifRDVToolStripMenuItem
            // 
            this.motifRDVToolStripMenuItem.Name = "motifRDVToolStripMenuItem";
            this.motifRDVToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.motifRDVToolStripMenuItem.Text = "Motif RDV";
            // 
            // gSBOKDataSetBindingSource
            // 
            this.gSBOKDataSetBindingSource.DataSource = this.gSB_OKDataSet;
            this.gSBOKDataSetBindingSource.Position = 0;
            // 
            // gSB_OKDataSet
            // 
            this.gSB_OKDataSet.DataSetName = "GSB_OKDataSet";
            this.gSB_OKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compteRenduToolStripMenuItem
            // 
            this.compteRenduToolStripMenuItem.Name = "compteRenduToolStripMenuItem";
            this.compteRenduToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.compteRenduToolStripMenuItem.Text = "Compte-Rendu";
            this.compteRenduToolStripMenuItem.Click += new System.EventHandler(this.compteRenduToolStripMenuItem_Click);
            // 
            // Mission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mission2";
            this.Text = "Mission2";
            this.Load += new System.EventHandler(this.Mission2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSBOKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_OKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompteRendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem médecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motifRDVToolStripMenuItem;
        private System.Windows.Forms.BindingSource gSBOKDataSetBindingSource;
        private GSB_OKDataSet gSB_OKDataSet;
        private System.Windows.Forms.ToolStripMenuItem compteRenduToolStripMenuItem;
        private System.Windows.Forms.BindingSource CompteRendu;
    }
}