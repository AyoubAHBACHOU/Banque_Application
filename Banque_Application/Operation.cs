using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_Application
{
    public abstract class Operation
    {
        static long incr = 0;
        readonly long _numT = ++incr;
        DateTime _date_heure;
        Devise _Val;
        Compte _compte;
        public Operation(Devise Val, Compte compte)
        {
            _Val = Val;
            _compte = compte;
            _date_heure = DateTime.Now;
        }
        protected string Details()
        {
            return "Date/heure:" + _date_heure + " \n Operation numero:" + _numT;
        }
        protected string Montant()
        {
            return _Val.ToString();
        }
    }
    public class OpR : Operation
    {
        static string libel = "-";
        public OpR(Devise Value, Compte compte) : base(Value, compte)
        {
        }
        public override string ToString()
        {
            return Details() + "\nMantant:" + libel + Montant();
        }
    }
    public class OpV : Operation
    {
        static string libel = "+";
        public OpV(Devise Value, Compte compte) : base(Value, compte)
        {
        }
        public override string ToString()
        {
            return Details() + "\nMantant:" + libel + Montant();
        }
    }
}
