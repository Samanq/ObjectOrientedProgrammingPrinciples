namespace AbstractionSample;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    // Exposing only this method to the client.
    public void Validate()
    {
        ValidateName();
        ValidateAddress();
    }

    // There is no reason that client can see this method.
    private void ValidateName()
    {
        if (Name.Length < 3)
        {
            Console.WriteLine($"{Name} is not valid");
        }
        else
        {
            Console.WriteLine($"{Name} is valid");
        }
    }

    // There is no reason that client can see this method.
    private void ValidateAddress()
    {
        if (Address.Length < 3)
        {
            Console.WriteLine($"{Address} is not valid");
        }
        else
        {
            Console.WriteLine($"{Address} is valid");
        }
    }
}
