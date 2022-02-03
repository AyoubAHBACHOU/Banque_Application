
namespace Banque_UI
{
    partial class Home
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.Inscri = new System.Windows.Forms.Label();
            this.tb_cin = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.inscription = new System.Windows.Forms.Button();
            this.SeConnecter = new System.Windows.Forms.Button();
            this.lgn_cnn = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.lg = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(157, 64);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 0;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(157, 90);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 20);
            this.tb_prenom.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(50, 67);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 2;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(50, 93);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 3;
            this.Prenom.Text = "Prenom";
            this.Prenom.Click += new System.EventHandler(this.Prenom_Click);
            // 
            // Inscri
            // 
            this.Inscri.AutoSize = true;
            this.Inscri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inscri.Location = new System.Drawing.Point(53, 26);
            this.Inscri.Name = "Inscri";
            this.Inscri.Size = new System.Drawing.Size(66, 13);
            this.Inscri.TabIndex = 4;
            this.Inscri.Text = "Inscription";
            // 
            // tb_cin
            // 
            this.tb_cin.Location = new System.Drawing.Point(157, 116);
            this.tb_cin.Name = "tb_cin";
            this.tb_cin.Size = new System.Drawing.Size(100, 20);
            this.tb_cin.TabIndex = 5;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(157, 142);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(100, 20);
            this.tb_adresse.TabIndex = 6;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(157, 168);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(157, 194);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 8;
            // 
            // cin
            // 
            this.cin.AutoSize = true;
            this.cin.Location = new System.Drawing.Point(50, 119);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(25, 13);
            this.cin.TabIndex = 9;
            this.cin.Text = "CIN";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(50, 145);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(45, 13);
            this.Adresse.TabIndex = 10;
            this.Adresse.Text = "Adresse";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(50, 171);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 11;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(50, 197);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 12;
            this.password.Text = "Password";
            // 
            // inscription
            // 
            this.inscription.Location = new System.Drawing.Point(182, 230);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(75, 23);
            this.inscription.TabIndex = 13;
            this.inscription.Text = "S\' inscrire";
            this.inscription.UseVisualStyleBackColor = true;
            this.inscription.Click += new System.EventHandler(this.inscription_Click);
            // 
            // SeConnecter
            // 
            this.SeConnecter.Location = new System.Drawing.Point(425, 116);
            this.SeConnecter.Name = "SeConnecter";
            this.SeConnecter.Size = new System.Drawing.Size(97, 29);
            this.SeConnecter.TabIndex = 14;
            this.SeConnecter.Text = "Se connecter";
            this.SeConnecter.UseVisualStyleBackColor = true;
            this.SeConnecter.Click += new System.EventHandler(this.SeConnecter_Click);
            // 
            // lgn_cnn
            // 
            this.lgn_cnn.AutoSize = true;
            this.lgn_cnn.Location = new System.Drawing.Point(351, 67);
            this.lgn_cnn.Name = "lgn_cnn";
            this.lgn_cnn.Size = new System.Drawing.Size(33, 13);
            this.lgn_cnn.TabIndex = 15;
            this.lgn_cnn.Text = "Login";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(351, 93);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(53, 13);
            this.pwd.TabIndex = 16;
            this.pwd.Text = "Password";
            // 
            // lg
            // 
            this.lg.Location = new System.Drawing.Point(410, 64);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(100, 20);
            this.lg.TabIndex = 17;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(410, 90);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(100, 20);
            this.tb_pwd.TabIndex = 18;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.lgn_cnn);
            this.Controls.Add(this.SeConnecter);
            this.Controls.Add(this.inscription);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_cin);
            this.Controls.Add(this.Inscri);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Name = "Home";
            this.Text = "Home_page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Inscri;
        private System.Windows.Forms.TextBox tb_cin;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label cin;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.Button SeConnecter;
        private System.Windows.Forms.Label lgn_cnn;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox lg;
        private System.Windows.Forms.TextBox tb_pwd;
    }
}

