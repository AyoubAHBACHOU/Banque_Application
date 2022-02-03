using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_Application
{
    public class MAD:Devise
    {
        //conversion 25/01/2022
        static readonly double RatioToDollar = 0.11;
        static readonly double RatioToEuro = 0.096;
        public MAD(double valeur) : base(valeur) 
        { }
        public MAD(MAD M) : base(M) 
        { }
        public override Devise Copie()
        {
            return new MAD(this);
        }
        public override string ToString()
        {
            return base.ToString() + "DH";
        }
        public override Dollar ConverToDollar()
        {
            return new Dollar(convert(RatioToDollar));
        }
        public override MAD ConverToMAD()
        {
            return (MAD)Copie();
        }
        public override Euro ConverToEuro()
        {
            return new Euro(convert(RatioToEuro));
        }
    }
    public class Euro : Devise
    {
        //conversion 25/01/2022
        static readonly double RatioToDollar = 1.13;
        static readonly double RatioToMAD = 10.48;
        public Euro(double valeur) : base(valeur) { }
        public Euro(Euro valeur) : base(valeur) { }
        public override Devise Copie()
        {
            return new Euro(this);
        }

        public override string ToString()
        {
            return base.ToString() + "€";
        }
        public override Dollar ConverToDollar()
        {
            return new Dollar(convert(RatioToDollar));
        }
        public override MAD ConverToMAD()
        {
            return new MAD(convert(RatioToMAD));
        }
        public override Euro ConverToEuro()
        {
            return (Euro)Copie();
        }
    }
    public class Dollar : Devise
    {
        //conversion 25/01/2022
        static readonly double RatioToMAD = 9.29;
        static readonly double RatioToEuro = 0.89;
        public Dollar(double valeur) : base(valeur) { }
        public Dollar(Dollar valeur) : base(valeur) { }
        public override Devise Copie()
        {
            return new Dollar(this);
        }
        public override string ToString()
        {
            return base.ToString() + "$";
        }
        public override Dollar ConverToDollar()
        {
            return (Dollar)Copie();
        }
        public override MAD ConverToMAD()
        {
            return new MAD(convert(RatioToMAD));
        }
        public override Euro ConverToEuro()
        {
            return new Euro(convert(RatioToEuro));
        }
    }
}
