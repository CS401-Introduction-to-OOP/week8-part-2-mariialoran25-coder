namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;        // Ось тут boxing створення копія в хіпі
        object obj = a;   // Тобто приведення ValueTypes до Reference Type. Тобто преретворюю а на об'єкт 

                            // Ось тут unboxing, створила нову копію в стек, а оригінал в хіпі
        int ca = (int)obj;   // тут навпаки приведення Reference Type до ValueTypes

        Console.WriteLine($"a: {a}, obj: {obj}, c: {ca}");
        
        
    }
}