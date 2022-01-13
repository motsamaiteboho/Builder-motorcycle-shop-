/*
 * Student Names: Motsamai Teboho
 * Student Number: 2016206381
 * */
using System;
using System.IO;

namespace Builder_motorcycle_shop_
{
    class Client
    {
        static void Main(string[] args)
        {
            //Black text on white background
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();
            //Director
            BikeMaker director = new BikeMaker();
            //Read file with test data
            string[] lines = File.ReadAllLines("Bikes.txt");
            //Step through lines
            foreach (string line in lines)
            {
                //Get separate data fields
                string[] fields = line.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
                //Bike builder
                IBikeBuilder bikeBuilder;
                switch (fields[0])
                {
                    case "Adventure": bikeBuilder = new AdventureBuilder(); break;
                    case "Cruiser": bikeBuilder = new CruiserBuilder(); break;
                    case "Naked": bikeBuilder = new NakedBuilder(); break;
                    case "Off-road": bikeBuilder = new OffroadBuilder(); break;
                    case "Off-road adventure":
                    bikeBuilder = new OffroadAdventureBuilder(); break;
                    case "Scooter": bikeBuilder = new ScooterBuilder(); break;
                    case "Sports": bikeBuilder = new SportsBuilder(); break;
                    case "Sports-tourer": bikeBuilder = new SportsTourerBuilder(); break;
                    default: bikeBuilder = null; break;
                } //switch
                  //Make bike and display details
                if (bikeBuilder != null)
                {
                    director.MakeBike(bikeBuilder,
                    fields[1].Trim(), fields[2].Trim(),
                    double.Parse(fields[3]),
                    fields[4].Trim(), int.Parse(fields[5]),
                    decimal.Parse(fields[6])
                    );
                    Motorbike bike = bikeBuilder.GetBike();
                    Console.WriteLine(bike.GetDetails());
                    Console.WriteLine("\n");
                } //if builder != null
            } //foreach
            Console.ReadKey();
        } //Main
    }//The Liskov Substition Principle (LSP) 
}
