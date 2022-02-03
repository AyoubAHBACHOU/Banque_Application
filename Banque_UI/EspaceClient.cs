using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banque_Application;
namespace Banque_UI
{
    public partial class EspaceClient : Form
    {
        ClientB c;
        public EspaceClient(ClientB client)
        {
            c = client;
            InitializeComponent();
        }

        private void EspaceClient_Load(object sender, EventArgs e)
        {
            user_name.Text = c._nom+ " " +c._prenom;
            
        }

        private void ajouter_compte_Click(object sender, EventArgs e)
        {
            Form ajout = new Ajout_Compte(c);
            ajout.Show();
        }

        private void afficher_comptes_Click(object sender, EventArgs e)
        {
            comptes.AutoSize = false;
            //List<CompteB> l = new List<CompteB>(c._comptes);
            comptes.DataSource = c._comptes;
        }
    }
}
