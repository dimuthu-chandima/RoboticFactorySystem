class ServiceRobot : Robot
{
    public string ServiceTask { get; set; }

    public override void ShowDetails()
    {
        Console.WriteLine("Service Robot");
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
        Console.WriteLine("Service Task: " + ServiceTask);
    }
}