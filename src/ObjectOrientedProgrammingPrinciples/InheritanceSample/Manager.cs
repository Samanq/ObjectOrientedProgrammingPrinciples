namespace InheritanceSample;

public class Manager : Employee
{
    public void Manage()
    {
        Console.WriteLine($"{base.Name} is managing.");
    }
}
