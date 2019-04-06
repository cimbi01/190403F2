using System;

namespace _190403F2
{
    internal static class Test
    {
        #region Public Methods

        public static double Terfogat(double a, double m)
        {
            return a * m;
        }

        #endregion Public Methods
    }
    internal class Program
    {
        #region Private Delegates

        private delegate double terfogat(double a, double b);

        #endregion Private Delegates

        #region Private Methods

        private static void Main(string[] args)
        {
            terfogat terfogatszamitas = new terfogat(Test.Terfogat);
            double szam1 = AdatBekeres.EllenorzottBekeres<double>("Add meg az egyik számot");
            double szam2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a másik számot");
            Console.WriteLine(terfogatszamitas(szam1, szam2));
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}
