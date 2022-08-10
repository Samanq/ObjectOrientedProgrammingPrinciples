using CustomOperatorOverloadingSample;

Student john = new Student("John", 10);
Student jane = new Student("Jane", 15);

Student both = john + jane;

Console.WriteLine($"Students: {both.Name} \nPoints: {both.Point}");
