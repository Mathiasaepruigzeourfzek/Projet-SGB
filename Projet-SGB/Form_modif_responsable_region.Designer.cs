namespace Projet_SGB
{
    partial class Form_modif_responsable_region
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_choix_region = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_choix_responsable = new System.Windows.Forms.ComboBox();
            this.bindingSource_region = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_visiteur = new System.Windows.Forms.BindingSource(this.components);
            this.button_valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_visiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisissez une région :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_choix_region
            // 
            this.comboBox_choix_region.FormattingEnabled = true;
            this.comboBox_choix_region.Location = new System.Drawing.Point(69, 71);
            this.comboBox_choix_region.Name = "comboBox_choix_region";
            this.comboBox_choix_region.Size = new System.Drawing.Size(157, 21);
            this.comboBox_choix_region.TabIndex = 2;
            this.comboBox_choix_region.SelectedIndexChanged += new System.EventHandler(this.comboBox_choix_region_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choisissez un remplaçant :";
            // 
            // comboBox_choix_responsable
            // 
            this.comboBox_choix_responsable.FormattingEnabled = true;
            this.comboBox_choix_responsable.Location = new System.Drawing.Point(69, 147);
            this.comboBox_choix_responsable.Name = "comboBox_choix_responsable";
            this.comboBox_choix_responsable.Size = new System.Drawing.Size(157, 21);
            this.comboBox_choix_responsable.TabIndex = 4;
            // 
            // bindingSource_region
            // 
            this.bindingSource_region.CurrentChanged += new System.EventHandler(this.bindingSource_region_CurrentChanged);
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(111, 193);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 5;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // Form_modif_responsable_region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 251);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.comboBox_choix_responsable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_choix_region);
            this.Controls.Add(this.label1);
            this.Name = "Form_modif_responsable_region";
            this.Text = "Form_modif_responsable_region";
            this.Load += new System.EventHandler(this.Form_modif_responsable_secteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_visiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_choix_region;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_choix_responsable;
        private System.Windows.Forms.BindingSource bindingSource_region;
        private System.Windows.Forms.BindingSource bindingSource_visiteur;
        private System.Windows.Forms.Button button_valider;
    }
}