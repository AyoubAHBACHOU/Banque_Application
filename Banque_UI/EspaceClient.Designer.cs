
namespace Banque_UI
{
    partial class EspaceClient
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
            this.user_name = new System.Windows.Forms.Label();
            this.comptes = new System.Windows.Forms.DataGridView();
            this.compte_lab = new System.Windows.Forms.Label();
            this.ajouter_compte = new System.Windows.Forms.Button();
            this.afficher_comptes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comptes)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(487, 9);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(0, 13);
            this.user_name.TabIndex = 0;
            // 
            // comptes
            // 
            this.comptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comptes.Location = new System.Drawing.Point(39, 58);
            this.comptes.Name = "comptes";
            this.comptes.Size = new System.Drawing.Size(393, 150);
            this.comptes.TabIndex = 1;
            // 
            // compte_lab
            // 
            this.compte_lab.AutoSize = true;
            this.compte_lab.Location = new System.Drawing.Point(39, 39);
            this.compte_lab.Name = "compte_lab";
            this.compte_lab.Size = new System.Drawing.Size(73, 13);
            this.compte_lab.TabIndex = 2;
            this.compte_lab.Text = "Mes comptes:";
            // 
            // ajouter_compte
            // 
            this.ajouter_compte.Location = new System.Drawing.Point(336, 215);
            this.ajouter_compte.Name = "ajouter_compte";
            this.ajouter_compte.Size = new System.Drawing.Size(95, 23);
            this.ajouter_compte.TabIndex = 3;
            this.ajouter_compte.Text = "Creer_compte";
            this.ajouter_compte.UseVisualStyleBackColor = true;
            this.ajouter_compte.Click += new System.EventHandler(this.ajouter_compte_Click);
            // 
            // afficher_comptes
            // 
            this.afficher_comptes.Location = new System.Drawing.Point(219, 215);
            this.afficher_comptes.Name = "afficher_comptes";
            this.afficher_comptes.Size = new System.Drawing.Size(111, 23);
            this.afficher_comptes.TabIndex = 4;
            this.afficher_comptes.Text = "Mes comptes";
            this.afficher_comptes.UseVisualStyleBackColor = true;
            this.afficher_comptes.Click += new System.EventHandler(this.afficher_comptes_Click);
            // 
            // EspaceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.afficher_comptes);
            this.Controls.Add(this.ajouter_compte);
            this.Controls.Add(this.compte_lab);
            this.Controls.Add(this.comptes);
            this.Controls.Add(this.user_name);
            this.Name = "EspaceClient";
            this.Text = "la";
            this.Load += new System.EventHandler(this.EspaceClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comptes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.DataGridView comptes;
        private System.Windows.Forms.Label compte_lab;
        private System.Windows.Forms.Button ajouter_compte;
        private System.Windows.Forms.Button afficher_comptes;
    }
}