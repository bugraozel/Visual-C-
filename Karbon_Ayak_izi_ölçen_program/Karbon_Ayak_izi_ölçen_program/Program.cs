using System;

class CarbonFootprintCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Karbon Ayak İzi Hesaplayıcı");

        double electricityConsumption;
        double gasConsumption;
        double kilometersDriven;
        double wasteProduced;

        Console.Write("Elektrik Tüketimi (kWh): ");
        electricityConsumption = double.Parse(Console.ReadLine());

        Console.Write("Doğalgaz Tüketimi (metreküp): ");
        gasConsumption = double.Parse(Console.ReadLine());

        Console.Write("Sürülen Kilometre (km): ");
        kilometersDriven = double.Parse(Console.ReadLine());

        Console.Write("Üretilen Atık (kg): ");
        wasteProduced = double.Parse(Console.ReadLine());

        double carbonFootprint = CalculateCarbonFootprint(electricityConsumption, gasConsumption, kilometersDriven, wasteProduced);

        Console.WriteLine($"Karbon Ayak İzi: {carbonFootprint} ton CO2 eşdeğeri");

        Console.ReadLine();
    }

    static double CalculateCarbonFootprint(double electricityConsumption, double gasConsumption, double kilometersDriven, double wasteProduced)
    {
        double electricityEmissions = electricityConsumption * 0.5; 
        double gasEmissions = gasConsumption * 1.2; 
        double transportationEmissions = kilometersDriven * 0.621371 * 0.45; 
        double wasteEmissions = wasteProduced * 0.1;

        double totalEmissions = electricityEmissions + gasEmissions + transportationEmissions + wasteEmissions;

        return totalEmissions;
    }
}
