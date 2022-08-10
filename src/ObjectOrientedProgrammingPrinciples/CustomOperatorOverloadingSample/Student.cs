namespace CustomOperatorOverloadingSample;

public class Student
{
    public string Name { get; set; }
    public int Point { get; set; }

    public Student(string name, int point)
    {
        Name = name;
        Point = point;
    }

    public static Student operator +(Student arg1, Student arg2)
    {
        return new Student($"{arg1.Name}, {arg2.Name}", arg1.Point + arg2.Point);
    }
}
