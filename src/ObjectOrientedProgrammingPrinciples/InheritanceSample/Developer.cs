namespace InheritanceSample;

public class Developer : Employee
{
    public void Develope()
    {
        Console.WriteLine($"{base.Name} is developing");
    }
}
