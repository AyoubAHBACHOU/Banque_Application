﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_Application
{
    public class Client
    {
        public string _CIN, _nom, _prenom, _adresse;
        private string _login, _password;
        public int id;
        public List<Compte> _comptes;
        public Client(string cIN, string nom, string prenom, string adr)
        {
            _CIN = cIN;
            _adresse = adr;
            this._nom = nom;
            this._prenom = prenom;
            _comptes = new List<Compte>();
        }

        public Client(int id, string cIN, string nom, string prenom, string adr, string login, string password) 
        {

            this.id = id;
            _CIN = cIN;
            _adresse = adr;
            this._nom = nom;
            this._prenom = prenom;
            _comptes = new List<Compte>();
            _login = login;
            _password = password;

        }
        public Client(string cIN, string nom, string prenom, string adresse, string login, string password) : this(cIN, nom, prenom, adresse)
        {
            _login = login;
            _password = password;
        }
        

        public void add_Compte(Compte se)
        {
            if (_comptes.Contains(se)) return;
            _comptes.Add(se);
        }
        public override string ToString()
        {
            return "CIN =" + _CIN + " nom=" + _nom + " prenom=" + _prenom + " addresse=" + _adresse;
        }
        public bool auth(string login, string pass)
        {
            return login == _login && pass == _password;
        }
    }
}
