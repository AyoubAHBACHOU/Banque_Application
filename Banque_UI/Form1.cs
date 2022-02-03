using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Banque_Application;
namespace Banque_UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void conn_bd(SqlConnection c)
        {
            String connString;
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque_App;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            c = new SqlConnection(connString);
            c.Open();
        }
        private void Insert_Com(string com,SqlConnection sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(com, sql);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.InsertCommand.Dispose();
        }
        private void Prenom_Click(object sender, EventArgs e)
        {

        }

        private void inscription_Click(object sender, EventArgs e)
        {
            if(tb_nom.Text.Length==0|| tb_prenom.Text.Length == 0|| tb_cin.Text.Length == 0|| tb_adresse.Text.Length == 0|| tb_login.Text.Length == 0|| tb_password.Text.Length == 0)
            {
                MessageBox.Show("vous devez remplire les champs");
            }
            else
            {
                SqlConnection c;
                //conn_bd(c);
                String connString;
                connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque_App;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                c = new SqlConnection(connString);
                c.Open();
                string req = "Select max(Id) as m from Client ";
                SqlCommand commande = new SqlCommand(req, c);
                SqlDataReader reader = commande.ExecuteReader();
                int id;
                if (!reader.Read())
                {
                    id = 1;
                    //id = int.Parse(reader["m"].ToString());
                    //id += 1;
                }
                else
                {
                    id = int.Parse(reader["m"].ToString())+1;
                }
                    
                commande.Dispose();
                reader.Close();

                //Client clt = new Client(id,tb_cin.Text,tb_nom.Text,tb_prenom.Text,tb_adresse.Text,tb_login.Text,tb_password.Text);
                //inserer client
                SqlDataAdapter adapter = new SqlDataAdapter();
                string req1= "insert into Client(Id,CIN,nom,prenom,adresse,login,password) values("+id+",'"+tb_cin.Text+"','"+tb_nom.Text+"','"+tb_prenom.Text+"','"+tb_adresse.Text+"','"+tb_login.Text+"','"+tb_password.Text+"')";
                SqlCommand commande2 = new SqlCommand(req1, c);
                adapter.InsertCommand = commande2;
                adapter.InsertCommand.ExecuteNonQuery();
                commande2.Dispose();
                tb_nom.Clear();
                tb_prenom.Clear();
                tb_cin.Clear();
                tb_login.Clear();
                tb_password.Clear();
                tb_adresse.Clear();
                c.Close();
                MessageBox.Show("Votre profil a été bien crée, connecter vous pour créer votre comptes");
                
            }
        }

        private void SeConnecter_Click(object sender, EventArgs e)
        {
            if (lg.Text.Length == 0 || tb_pwd.Text.Length == 0)
            {
                MessageBox.Show("vous devez remplir tous les champs");
            }
            else
            {

                SqlConnection c;
                String connString;
                connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque_App;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                c = new SqlConnection(connString);
                c.Open();
                SqlCommand commande;
                SqlDataReader reader;
                string qr = "select * from Client where login='" + lg.Text + "'and password='"+tb_pwd.Text+"'";
                commande = new SqlCommand(qr, c);
                reader = commande.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["password"].ToString() == tb_pwd.Text && reader["login"].ToString() == lg.Text)
                    {
                        ClientB client;
                        client = new ClientB(int.Parse(reader["Id"].ToString()), reader["CIN"].ToString(), reader["nom"].ToString(), reader["prenom"].ToString(), reader["adresse"].ToString(), reader["login"].ToString(), reader["password"].ToString());
                        reader.Close();
                        commande.Dispose();
                        //ajouter à ce clients ses comptes
                        string rq = "select * from Compte where id_client=" + client.id + "";
                        commande = new SqlCommand(rq, c);
                        reader = commande.ExecuteReader();
                        while (reader.Read())
                        {
                            CompteB cpt = new CompteB(int.Parse(reader["id"].ToString()),double.Parse(reader["solde"].ToString()));
                            client.add_Compte(cpt);
                        }
                        Form EspaceClient = new EspaceClient(client);
                        EspaceClient.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("mdp incorrect");
                }
                else MessageBox.Show("Ce compte n'existe pas");
            }

        }
    }
}
