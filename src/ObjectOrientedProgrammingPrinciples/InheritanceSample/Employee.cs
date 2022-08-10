namespace InheritanceSample;

public class Employee
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty ;

    // With virtual keyword, child class can override this method and define it itself.
    public virtual void StartWorking()
    {

    }

    public void Validate()
    {
        ValidateName();
        ValidateAddress();
    }


    // We hide these method for abstraction purpose.
    private void ValidateName()
    {
        if (Name.Length < 3)
        {
            Console.WriteLine($"{Name} is not a valid {nameof(Name)}");
        }
        else
        {
            Console.WriteLine($"{Name} is a valid {nameof(Name)}");
        }
    }
    private void ValidateAddress()
    {
        if (Name.Length < 3)
        {
            Console.WriteLine($"{Address} is not a valid {nameof(Address)}");
        }
        else
        {
            Console.WriteLine($"{Address} is a valid {nameof(Address)}");
        }
    }
}
