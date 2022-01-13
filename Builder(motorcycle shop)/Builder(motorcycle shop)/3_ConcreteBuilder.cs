/*
 * Student Names: Motsamai Teboho
 * Student Number: 2016206381
 * */
namespace Builder_motorcycle_shop_
{
    public abstract class BikeBuilder
    {
        protected Motorbike bike = null;
        public void SetIndividualAttributes(string Manufacturer, string Model, string VIN, double EngineCapacity, int Year, decimal Price)
        {
            bike.Manufacturer = Manufacturer;
            bike.Model = Model;
            bike.VIN = VIN;
            bike.EngineCapacity = EngineCapacity;
            bike.Year = Year;
            bike.Price = Price;
        }

        public Motorbike GetBike()
        {
            return bike;
        }
    }

    class AdventureBuilder : BikeBuilder, IBikeBuilder
    {
        public AdventureBuilder()
        {
            bike = new Motorbike("Adventure");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.Upright;
            bike.ScreenType = ScreenType.Medium;
            bike.LuggageCarriers = true;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Good;
            bike.HandQuards = true;
            bike.CrashProtection = CrashProtection.Some;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.High;
            bike.Pillion = Pillion.Yes;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Spokes;
            bike.GroundClearance = GroundClearance.High;
            bike.SuspensionTravel = SuspensionTravel.Long;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Heavy;
            bike.FuelCapacity = FuelCapacity.High;
            bike.Instruments = Instruments.AllTheToys;
        }
    }
    class CruiserBuilder : BikeBuilder, IBikeBuilder
    {
        public CruiserBuilder()
        {
            bike = new Motorbike("Cruiser");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.Relaxed;
            bike.ScreenType = ScreenType.None;
            bike.LuggageCarriers = false;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.None;
            bike.HandQuards = false;
            bike.CrashProtection = CrashProtection.None;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.VeryLow;
            bike.Pillion = Pillion.None;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Cast;
            bike.GroundClearance = GroundClearance.Low;
            bike.SuspensionTravel = SuspensionTravel.Short;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.VeryHeavy;
            bike.FuelCapacity = FuelCapacity.Medium;
            bike.Instruments = Instruments.Standard;
        }
    }
    class NakedBuilder : BikeBuilder, IBikeBuilder
    {
        public NakedBuilder()
        {
            bike = new Motorbike("Naked");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.SemiSporty;
            bike.ScreenType = ScreenType.None;
            bike.LuggageCarriers = false;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Minimal;
            bike.HandQuards = false;
            bike.CrashProtection = CrashProtection.None;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.Medium;
            bike.Pillion = Pillion.Small;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Cast;
            bike.GroundClearance = GroundClearance.Medium;
            bike.SuspensionTravel = SuspensionTravel.Medium;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Light;
            bike.FuelCapacity = FuelCapacity.Low;
            bike.Instruments = Instruments.Minimal;
        }
    }
    class OffroadBuilder : BikeBuilder, IBikeBuilder
    {
        public OffroadBuilder()
        {
            bike = new Motorbike("Offroad");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.Standing;
            bike.ScreenType = ScreenType.None;
            bike.LuggageCarriers = false;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Minimal;
            bike.HandQuards = false;
            bike.CrashProtection = CrashProtection.None;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.VeryHigh;
            bike.Pillion = Pillion.None;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Spokes;
            bike.GroundClearance = GroundClearance.VeryHigh;
            bike.SuspensionTravel = SuspensionTravel.VeryLong;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Light;
            bike.FuelCapacity = FuelCapacity.Low;
            bike.Instruments = Instruments.Standard;
        }
    }
    class OffroadAdventureBuilder : BikeBuilder, IBikeBuilder
    {
        public OffroadAdventureBuilder()
        {
            bike = new Motorbike("Off-road adventure");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.Upright;
            bike.ScreenType = ScreenType.Low;
            bike.LuggageCarriers = true;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Minimal;
            bike.HandQuards = true;
            bike.CrashProtection = CrashProtection.Much;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.VeryHigh;
            bike.Pillion = Pillion.Yes;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Spokes;
            bike.GroundClearance = GroundClearance.VeryHigh;
            bike.SuspensionTravel = SuspensionTravel.VeryLong;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Medium;
            bike.FuelCapacity = FuelCapacity.High;
            bike.Instruments = Instruments.Standard;
        }
    }
    class ScooterBuilder : BikeBuilder, IBikeBuilder
    {
        public ScooterBuilder()
        {
            bike = new Motorbike("Scooter");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.Relaxed;
            bike.ScreenType = ScreenType.None;
            bike.LuggageCarriers = false;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Good;
            bike.HandQuards = false;
            bike.CrashProtection = CrashProtection.None;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.Medium;
            bike.Pillion = Pillion.Small;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Cast;
            bike.GroundClearance = GroundClearance.Low;
            bike.SuspensionTravel = SuspensionTravel.Short;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Light;
            bike.FuelCapacity = FuelCapacity.Low;
            bike.Instruments = Instruments.Standard;
        }
    }
    class SportsBuilder : BikeBuilder, IBikeBuilder
    {
        public SportsBuilder()
        {
            bike = new Motorbike("Sports");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.VerySporty;
            bike.ScreenType = ScreenType.Low;
            bike.LuggageCarriers = false;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Good;
            bike.HandQuards = false;
            bike.CrashProtection = CrashProtection.None;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.Low;
            bike.Pillion = Pillion.Small;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Cast;
            bike.GroundClearance = GroundClearance.Low;
            bike.SuspensionTravel = SuspensionTravel.Medium;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Medium;
            bike.FuelCapacity = FuelCapacity.Low;
            bike.Instruments = Instruments.Standard;
        }
    }
    class SportsTourerBuilder : BikeBuilder, IBikeBuilder
    {
        public SportsTourerBuilder()
        {
            bike = new Motorbike("Sports- tourer");
        }

        public void SetRiderAttributess()
        {
            bike.RidingPosition = RidingPosition.VerySporty;
            bike.ScreenType = ScreenType.Medium;
            bike.LuggageCarriers = true;
        }
        public void SetProtectionAttributes()
        {
            bike.WindProtection = WindProtection.Good;
            bike.HandQuards = true;
            bike.CrashProtection = CrashProtection.None;
        }
        public void SetSeatAttributes()
        {
            bike.SeatHeight = SeatHeight.Medium;
            bike.Pillion = Pillion.Yes;
        }
        public void SetOffRoadCapabilityAttributes()
        {
            bike.Rim = Rim.Cast;
            bike.GroundClearance = GroundClearance.Low;
            bike.SuspensionTravel = SuspensionTravel.Medium;
        }
        public void SetBodyAndDashAttributes()
        {
            bike.Weight = Weight.Heavy;
            bike.FuelCapacity = FuelCapacity.VeryHigh;
            bike.Instruments = Instruments.Standard;
        }
    }
} //The Interface Segregation Principle (ISP)

