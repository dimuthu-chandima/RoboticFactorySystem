class IndustrialRobot : Robot
{
    public string IndustrialTasklike { get; set; }

    public override void ShowDetails()
    {
        Console.WriteLine("Industrial Robot");
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
        Console.WriteLine("Industrial Task: " + IndustrialTasklike);
    }
}