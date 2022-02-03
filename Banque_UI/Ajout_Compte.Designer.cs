
namespace Banque_UI
{
    partial class Ajout_Compte
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
            this.solde_label = new System.Windows.Forms.Label();
            this.tb_solde = new System.Windows.Forms.TextBox();
            this.insert_compte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solde_label
            // 
            this.solde_label.AutoSize = true;
            this.solde_label.Location = new System.Drawing.Point(62, 50);
            this.solde_label.Name = "solde_label";
            this.solde_label.Size = new System.Drawing.Size(34, 13);
            this.solde_label.TabIndex = 0;
            this.solde_label.Text = "Solde";
            // 
            // tb_solde
            // 
            this.tb_solde.Location = new System.Drawing.Point(137, 47);
            this.tb_solde.Name = "tb_solde";
            this.tb_solde.Size = new System.Drawing.Size(100, 20);
            this.tb_solde.TabIndex = 1;
            // 
            // insert_compte
            // 
            this.insert_compte.Location = new System.Drawing.Point(162, 85);
            this.insert_compte.Name = "insert_compte";
            this.insert_compte.Size = new System.Drawing.Size(75, 23);
            this.insert_compte.TabIndex = 2;
            this.insert_compte.Text = "Creer";
            this.insert_compte.UseVisualStyleBackColor = true;
            this.insert_compte.Click += new System.EventHandler(this.insert_compte_Click);
            // 
            // Ajout_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.insert_compte);
            this.Controls.Add(this.tb_solde);
            this.Controls.Add(this.solde_label);
            this.Name = "Ajout_Compte";
            this.Text = "Ajout_Compte";
            this.Load += new System.EventHandler(this.Ajout_Compte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label solde_label;
        private System.Windows.Forms.TextBox tb_solde;
        private System.Windows.Forms.Button insert_compte;
    }
}