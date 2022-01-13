/*
 * Student Names: Motsamai Teboho
 * Student Number: 2016206381
 * */

namespace Builder_motorcycle_shop_
{
    public interface IBikeBuilder
    {
        void SetIndividualAttributes(string Manufacturer, string Model, string VIN, double EngineCapacity, int Year, decimal Price);
        void SetRiderAttributess();
        void SetProtectionAttributes();
        void SetSeatAttributes();
        void SetOffRoadCapabilityAttributes();
        void SetBodyAndDashAttributes();

        Motorbike GetBike();
    }
}
