namespace Projet_SGB
{
    partial class Mission3
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
            this.btnconsulterpaye = new System.Windows.Forms.Button();
            this.btnfichepaye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconsulterpaye
            // 
            this.btnconsulterpaye.Location = new System.Drawing.Point(448, 165);
            this.btnconsulterpaye.Name = "btnconsulterpaye";
            this.btnconsulterpaye.Size = new System.Drawing.Size(185, 48);
            this.btnconsulterpaye.TabIndex = 1;
            this.btnconsulterpaye.Text = "Consulter fiche de paye";
            this.btnconsulterpaye.UseVisualStyleBackColor = true;
            this.btnconsulterpaye.Click += new System.EventHandler(this.btnconsulterpaye_Click);
            // 
            // btnfichepaye
            // 
            this.btnfichepaye.Location = new System.Drawing.Point(164, 165);
            this.btnfichepaye.Name = "btnfichepaye";
            this.btnfichepaye.Size = new System.Drawing.Size(185, 48);
            this.btnfichepaye.TabIndex = 2;
            this.btnfichepaye.Text = "Fiche de paye";
            this.btnfichepaye.UseVisualStyleBackColor = true;
            this.btnfichepaye.Click += new System.EventHandler(this.btnfichepaye_Click);
            // 
            // Mission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfichepaye);
            this.Controls.Add(this.btnconsulterpaye);
            this.Name = "Mission3";
            this.Text = "Mission3";
            this.Load += new System.EventHandler(this.Mission3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnconsulterpaye;
        private System.Windows.Forms.Button btnfichepaye;
    }
}