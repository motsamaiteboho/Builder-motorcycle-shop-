/*
 * Student Names: Motsamai Teboho
 * Student Number: 2016206381
 * */

namespace Builder_motorcycle_shop_
{
    public class BikeMaker
    {
        public void MakeBike(IBikeBuilder builder, string Manufacturer, string Model, double EngineCapacity,string VIN, int Year, decimal Price)
        {
            builder.SetIndividualAttributes(Manufacturer,Model,VIN,EngineCapacity,Year,Price);
            builder.SetRiderAttributess();
            builder.SetProtectionAttributes();
            builder.SetSeatAttributes();
            builder.SetOffRoadCapabilityAttributes();
            builder.SetBodyAndDashAttributes();
        }
    }
}
