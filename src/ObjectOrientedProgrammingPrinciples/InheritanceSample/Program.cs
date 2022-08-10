using InheritanceSample;

// Both developer and manager are employees.
// But the have diffrent behaviors.
// deveoper has develope method and manager has manage method.

Developer developer =  new Developer 
{
    Name = "John",
    Address = "Doe"
};

Manager manager = new Manager 
{
    Name = "Jane",
    Address = "Doe"
};


developer.Develope();
manager.Manage();
