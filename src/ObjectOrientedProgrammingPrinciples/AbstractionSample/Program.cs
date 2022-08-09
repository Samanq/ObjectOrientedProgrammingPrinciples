using AbstractionSample;

User validUser = new User
{
    Name = "John",
    Address = "Planet earth"
};

User invalidUser = new User
{
    Name = "J",
    Address = "TH"
};

// We can only see the validate method, we hide the parts that are not nessecery.
validUser.Validate();
invalidUser.Validate();


Console.ReadKey();