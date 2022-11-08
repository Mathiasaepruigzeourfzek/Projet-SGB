namespace Projet_SGB
{
    partial class page_connexion
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
            this.components = new System.ComponentModel.Container();
            this.textBox_identifiant = new System.Windows.Forms.TextBox();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.label_identifiant = new System.Windows.Forms.Label();
            this.label_mdp = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.bindingSource_identifiant = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_visiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_mdp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_identifiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_visiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mdp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_identifiant
            // 
            this.textBox_identifiant.Location = new System.Drawing.Point(486, 179);
            this.textBox_identifiant.Name = "textBox_identifiant";
            this.textBox_identifiant.Size = new System.Drawing.Size(115, 20);
            this.textBox_identifiant.TabIndex = 3;
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.Location = new System.Drawing.Point(486, 236);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.PasswordChar = '*';
            this.textBox_mdp.Size = new System.Drawing.Size(115, 20);
            this.textBox_mdp.TabIndex = 4;
            this.textBox_mdp.TextChanged += new System.EventHandler(this.textBox_mdp_TextChanged);
            // 
            // label_identifiant
            // 
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.Location = new System.Drawing.Point(421, 182);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(59, 13);
            this.label_identifiant.TabIndex = 5;
            this.label_identifiant.Text = "Identifiant :";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Location = new System.Drawing.Point(403, 239);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(77, 13);
            this.label_mdp.TabIndex = 6;
            this.label_mdp.Text = "Mot de passe :";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(508, 282);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // bindingSource_identifiant
            // 
            this.bindingSource_identifiant.CurrentChanged += new System.EventHandler(this.bindingSource_identifiant_CurrentChanged);
            // 
            // bindingSource_visiteur
            // 
            this.bindingSource_visiteur.CurrentChanged += new System.EventHandler(this.bindingSource_mdp_CurrentChanged);
            // 
            // dataGridView_mdp
            // 
            this.dataGridView_mdp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mdp.Location = new System.Drawing.Point(12, 3);
            this.dataGridView_mdp.Name = "dataGridView_mdp";
            this.dataGridView_mdp.Size = new System.Drawing.Size(276, 544);
            this.dataGridView_mdp.TabIndex = 9;
            // 
            // page_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 559);
            this.Controls.Add(this.dataGridView_mdp);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_identifiant);
            this.Controls.Add(this.textBox_mdp);
            this.Controls.Add(this.textBox_identifiant);
            this.Name = "page_connexion";
            this.Text = "Page de connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_identifiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_visiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_identifiant;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.Label label_identifiant;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.BindingSource bindingSource_identifiant;
        private System.Windows.Forms.BindingSource bindingSource_visiteur;
        private System.Windows.Forms.DataGridView dataGridView_mdp;
    }
}

