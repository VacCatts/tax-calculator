using System;

namespace taxcalculator
{
    static class Taxcalculator
    {
        /*
        * growtopia tax calculator || taxcalculator.shibe.lol
        * hello! welcome to this shitty spaghetti code i wrote in like 15 minutes :D
        * i'm genuinely suprised it even works
        * this mf supports decimals too, which took me the most time to figure out (thanks stackoverflow)
        * and as always, i hope you enjoy this piece of garbage i made!
        * love, vaccat <3
        */
        
        public static void Main(string[] args) {
            Console.Clear();
            Console.Title = "growtopia tax calculator || taxcalculator.shibe.lol";
            Console.WriteLine("growtopia tax calculator || taxcalculator.shibe.lol");
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