namespace Vehicles
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }
        void RefuelTank();
        void DisplayGasTank();
    }
}