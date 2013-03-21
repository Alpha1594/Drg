using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegimeDatabaseCalculatorSystem
{
    public class cBSA       //BSA
    {
        public double BSA(double Height, double Weight) //BSA
        {
            double ans = 0.20247 * Math.Pow(Height, 0.725) * Math.Pow(Weight, 0.425);
            return ans;
        }
    }

    public class cCCr       //eCCR
    {
        public int CCR(int age , double Mass, double SCreat, string g ) //eCCR
        {
            double DAge =(double) age;
            double K;
            if (g == "M")
            /* { */
                K = 1.32;
            /* } */
            else
            /* { */
                K = 1.04;
            /* } */
            double calculations = ((140 - age) * Mass * K) / SCreat;
            int ans = (int) Math.Round(calculations, 0);
            return ans;
        }
    }

    public class cCalvert   //Calvert
    {
        public int Calvert(int AUC, int GFR) //Calvert
        {
            int ans = AUC * ( GFR + 25 );
            return ans;
        }
    }
}
