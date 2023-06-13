using System;

namespace taxcalculator
{
    static class Taxcalculator
    {
        public static void Main(string[] args) {
            Console.Clear();
            Console.Title = "tax calculator";
            Console.WriteLine("tax calculator");
            System.Threading.Thread.Sleep(3000);
            Menu();
        }

        public static void Menu() {
            Console.Clear();
            // get user input
            Console.WriteLine("what tax percentage?");
            var Itaxpercentage = Console.ReadLine();

            Console.WriteLine("bet amount? (world locks)");
            var Ibetamount = Console.ReadLine();

            // mathing
            int betamount = int.Parse(Ibetamount) * 2;
            double taxpercentage = double.Parse(Itaxpercentage, System.Globalization.CultureInfo.InvariantCulture);
            var result = Math.Round(betamount - ((taxpercentage / 100) * betamount));
            var youget = betamount - result;

            // assuming the calculation worked, print it
            Console.WriteLine($"give the winner {result}wls");
            Console.WriteLine($"you get {youget}wls tax");
            Console.WriteLine("press any key to go back");
            Console.ReadKey();
            Menu();
        }
    }
}
