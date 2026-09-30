using System;

class Program
{
    static void Main(string[] args)
    {
        ServiceRobot serviceRobot = new ServiceRobot
        {
            ModelName = "SR-100",
            BatteryCapacity = 12,
            SoftwareVersion = "1.0",
            ServiceTask = "Healthcare Assistance"
        };

        IndustrialRobot industrialRobot = new IndustrialRobot
        {
            ModelName = "IR-200",
            BatteryCapacity = 24,
            SoftwareVersion = "2.0",
            IndustrialTasklike = "Welding"
        };

        EntertainmentRobot entertainmentRobot = new EntertainmentRobot
        {
            ModelName = "ER-300",
            BatteryCapacity = 10,
            SoftwareVersion = "3.0",
            EntertainmentFeature = "Interactive Dancing"
        };

        ServiceRobot clonedServiceRobot = (ServiceRobot)serviceRobot.Clone();
        clonedServiceRobot.BatteryCapacity = 15;
        clonedServiceRobot.SoftwareVersion = "1.1";

        IndustrialRobot clonedIndustrialRobot = (IndustrialRobot)industrialRobot.Clone();
        clonedIndustrialRobot.BatteryCapacity = 30;
        clonedIndustrialRobot.SoftwareVersion = "2.1";

        EntertainmentRobot clonedEntertainmentRobot = (EntertainmentRobot)entertainmentRobot.Clone();
        clonedEntertainmentRobot.BatteryCapacity = 14;
        clonedEntertainmentRobot.SoftwareVersion = "3.1";

        serviceRobot.ShowDetails();
        Console.WriteLine();

        clonedServiceRobot.ShowDetails();
        Console.WriteLine();

        industrialRobot.ShowDetails();
        Console.WriteLine();

        clonedIndustrialRobot.ShowDetails();
        Console.WriteLine();

        entertainmentRobot.ShowDetails();
        Console.WriteLine();

        clonedEntertainmentRobot.ShowDetails();
    }
}