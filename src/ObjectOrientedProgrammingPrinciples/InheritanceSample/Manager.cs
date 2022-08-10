namespace InheritanceSample;

public class Manager : Employee
{
    public void Manage()
    {
        Console.WriteLine($"{base.Name} is managing.");
    }

    public override void StartWorking()
    {
        Console.WriteLine($"{Name} Taking right stairs to the office.");
    }
}
