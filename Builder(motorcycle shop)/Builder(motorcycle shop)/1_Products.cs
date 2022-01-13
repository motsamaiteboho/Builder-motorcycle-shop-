/*
 * Student Names: Motsamai Teboho
 * Student Number: 2016206381
 * */
namespace Builder_motorcycle_shop_
{
    public class Motorbike
    {
        //individual
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public double EngineCapacity { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //Group attributes
        public string MotorbikeName { get; }
        //Rider attributes
        public RidingPosition RidingPosition { get; set; }
        public ScreenType ScreenType { get; set; }
        public bool LuggageCarriers { get; set; }

        //Protection attributes
        public WindProtection WindProtection { get; set; }
        public bool HandQuards { get; set; }
        public CrashProtection CrashProtection { get; set; }

        //Seat attributes
        public SeatHeight SeatHeight { get; set; }
        public Pillion Pillion { get; set; }

        //Off-road capability attributes
        public Rim Rim { get; set; }
        public GroundClearance GroundClearance { get; set; }
        public SuspensionTravel SuspensionTravel { get; set; }

        //Body and Dash attributes
        public Weight Weight { get; set; }
        public FuelCapacity FuelCapacity { get; set; }
        public Instruments Instruments { get; set; }

        public Motorbike(string MotorbikeName)
        {
            this.MotorbikeName = MotorbikeName;
        }

        public string GetDetails()
        {
            return string.Format(  "Type            : {20}\n"
                                 + "Manufacturer    : {0}\nModel           : {1}\n"
                                 + "VIN             : {2}\nEngineCapacity  : {3}\n"
                                 + "Year            : {4}\nPrice           : {5}\n"
                                 + "RidingPosition  : {6}\nScreenType      : {7}\n"
                                 + "LuggageCarriers : {8}\nWindProtection  : {9}\n"
                                 + "HandQuards      : {10}\nCrashProtection : {11}\n"
                                 + "SeatHeight      : {12}\nPillion         : {13}\n"
                                 + "Rim             : {14}\nGroundClearance : {15}\n"
                                 + "SuspensionTravel: {16}\nWeight          : {17}\n"
                                 + "FuelCapacity    : {18}\nInstruments     : {19}",
                                 Manufacturer, Model,VIN, EngineCapacity,
                                 Year, Price.ToString("C"),RidingPosition, ScreenType,
                                 LuggageCarriers, WindProtection, HandQuards, CrashProtection,
                                 SeatHeight, Pillion,Rim, GroundClearance,
                                 SuspensionTravel, Weight,FuelCapacity, Instruments,MotorbikeName);
        } //GetDetails
    }
}
