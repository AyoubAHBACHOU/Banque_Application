using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Banque_Application;
namespace Banque_UI
{
    public partial class Ajout_Compte : Form
    {
        ClientB clt;
        public Ajout_Compte(ClientB client)
        {
            clt = client;
            InitializeComponent();
        }

        private void Ajout_Compte_Load(object sender, EventArgs e)
        {

        }

        private void insert_compte_Click(object sender, EventArgs e)
        {
            if (tb_solde.Text.Length == 0)
            {
                MessageBox.Show("vous devez donner le solde initial");
            }
            else
            {
                /***************chaine de connection******************/
                SqlConnection c;
                String connString;
                connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque_App;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                c = new SqlConnection(connString);
                c.Open();
                /********selection de l'id pour eviter la répitition *****************/
                string r0 = "Select max(Id) as max from Compte ";
                SqlCommand commande = new SqlCommand(r0, c);
                SqlDataReader reader = commande.ExecuteReader();
                int i;
                if (reader.Read().Equals(0)) i = 1;
                else i = int.Parse(reader["max"].ToString()) + 1;
                commande.Dispose();
                reader.Close();
                //creation d'un nouveau client
                CompteB compte = new CompteB(i, double.Parse(tb_solde.Text));
                
                //insertion
                SqlDataAdapter adapter = new SqlDataAdapter();
                string r = "insert into Compte ( Id,solde,id_client  ) values (" +i+ "," + compte._solde + "," + clt.id + ")";
                SqlCommand commande2 = new SqlCommand(r, c);
                adapter.InsertCommand = commande2;
                adapter.InsertCommand.ExecuteNonQuery();
                commande2.Dispose();
                c.Close();
                MessageBox.Show("Votre compte a été bien cré");
            }
        }
    }
}
