using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_Application
{
    class CompteEpargne:Compte
    {
        double _TauxInteret;
        public CompteEpargne(Client client, Devise solde, double taux) : base(client, solde)
        {
            if (taux >= 0 && taux <= 100) _TauxInteret = taux;
            else throw new ArgumentOutOfRangeException();
        }

        public CompteEpargne(int id, Client client, Devise solde, double taux) : base(id, client, solde)
        {
            if (taux >= 0 && taux <= 100) _TauxInteret = taux;
            else throw new ArgumentOutOfRangeException();
        }
        public void calculInteret()
        {
            add_pursontage(_TauxInteret);
        }
        public override bool debiter(Devise devise)
        {
            if (!this.check_moitier(devise)) return false;
            return base.debiter(devise);
        }
    }
}
