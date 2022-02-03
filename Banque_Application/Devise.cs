using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_Application
{
    public abstract class Devise
    {
        private double _valeur;

        public abstract Devise Copie();
        public abstract Dollar ConverToDollar();
        public abstract MAD ConverToMAD();
        public abstract Euro ConverToEuro();

        public Devise(double val)
        {
            _valeur = val;
        }

        public Devise(Devise d)
        {
            this._valeur = d._valeur;
        }

        public override string ToString()
        {
            return _valeur.ToString();
        }

        public double convert(double d)
        {
            return _valeur * d;        
        }

        public static Devise operator +(Devise devise, Devise d)
        {
            Devise dr = devise.Copie();
            dr._valeur += devise.ConvertToDev(d)._valeur;
            return dr;
        }

        public static Devise operator -(Devise devise, Devise d)
        {
            Devise dr = devise.Copie();
            dr._valeur -= devise.ConvertToDev(d)._valeur;
            return dr;
        }

        public static Devise operator *(Devise devise, double d)
        {
            Devise dr = devise.Copie();
            dr._valeur *= d;
            return dr;
        }

        public static Devise operator /(Devise devise, double d)
        {
            Devise dr = devise.Copie();
            try
            {
                dr._valeur /= d;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            return dr;
        }
        public static bool operator <=(Devise d1, Devise devise)
        {
            return d1._valeur <= d1.ConvertToDev(devise)._valeur;
        }
        public static bool operator >=(Devise d1, Devise devise)
        {
            return d1._valeur >= d1.ConvertToDev(devise)._valeur;
        }


        private Devise ConvertToDev(Devise d)
        {
            if (this.GetType()== d.GetType()) return d;
            if (this is Dollar) return d.ConverToDollar();
            if (this is MAD) return d.ConverToMAD();
            else 
                return d.ConverToEuro();
        }

    }
        
        

}
