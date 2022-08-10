namespace InheritanceSample;

public class Developer : Employee
{
    public void Develope()
    {
        Console.WriteLine($"{base.Name} is developing");
    }

    public override void StartWorking()
    {
        Console.WriteLine($"{Name} Taking left stairs to the office");
    }

}
