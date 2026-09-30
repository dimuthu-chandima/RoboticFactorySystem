abstract class Robot : IRobotPrototype
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }

    public abstract void ShowDetails();

    public IRobotPrototype Clone()
    {
        return (IRobotPrototype)MemberwiseClone();
    }
}