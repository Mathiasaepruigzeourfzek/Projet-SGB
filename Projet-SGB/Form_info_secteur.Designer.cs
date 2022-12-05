namespace Projet_SGB
{
    partial class Form_info_secteur
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
            this.dataGridView_liste_visiteur_secteur = new System.Windows.Forms.DataGridView();
            this.button_modif_responsable_region = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource_visiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_region = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_liste_visiteur_secteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_visiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_region)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_liste_visiteur_secteur
            // 
            this.dataGridView_liste_visiteur_secteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_liste_visiteur_secteur.Location = new System.Drawing.Point(348, 73);
            this.dataGridView_liste_visiteur_secteur.Name = "dataGridView_liste_visiteur_secteur";
            this.dataGridView_liste_visiteur_secteur.Size = new System.Drawing.Size(703, 606);
            this.dataGridView_liste_visiteur_secteur.TabIndex = 1;
            // 
            // button_modif_responsable_region
            // 
            this.button_modif_responsable_region.Location = new System.Drawing.Point(32, 21);
            this.button_modif_responsable_region.Name = "button_modif_responsable_region";
            this.button_modif_responsable_region.Size = new System.Drawing.Size(192, 23);
            this.button_modif_responsable_region.TabIndex = 2;
            this.button_modif_responsable_region.Text = "Modifier les responsables de régions";
            this.button_modif_responsable_region.UseVisualStyleBackColor = true;
            this.button_modif_responsable_region.Click += new System.EventHandler(this.button_modif_responsable_secteur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listes des visiteurs dans votre secteur";
            // 
            // bindingSource_visiteur
            // 
            this.bindingSource_visiteur.CurrentChanged += new System.EventHandler(this.bindingSource_visiteur_CurrentChanged);
            // 
            // Form_info_secteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_modif_responsable_region);
            this.Controls.Add(this.dataGridView_liste_visiteur_secteur);
            this.Name = "Form_info_secteur";
            this.Text = "Form_info_secteur";
            this.Load += new System.EventHandler(this.Form_info_secteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_liste_visiteur_secteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_visiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_region)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_liste_visiteur_secteur;
        private System.Windows.Forms.Button button_modif_responsable_region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource_visiteur;
        private System.Windows.Forms.BindingSource bindingSource_region;
    }
}