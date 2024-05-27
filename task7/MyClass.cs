namespace task7;

public class MyClass <T> where T: new()
{
    public static T FacrotyMethod()
    {
        return new T();
    }
}

public class ExtClass
{
    public void Test()
    {
        Console.WriteLine("Hellow");
    }
}