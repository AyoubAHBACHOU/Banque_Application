using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_Application
{
    public class CompteB
    {
        //static Devise plafond = new MAD(2000);
        //static int count = 0;
        public int id;
        //Client _client;
        public double _solde;
        //List<Operation> _Operations;

        public CompteB(int id, double solde)
        {
            this.id = id;
            //this._client = client;
            this._solde = solde;
            //_Operations = new List<Operation>();
            //_client.add_Compte(this);
        }
    }
}
