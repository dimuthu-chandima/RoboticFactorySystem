class EntertainmentRobot : Robot
{
    public string EntertainmentFeature { get; set; }

    public override void ShowDetails()
    {
        Console.WriteLine("Entertainment Robot");
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
        Console.WriteLine("Software Version: " + SoftwareVersion);
        Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
    }
}
