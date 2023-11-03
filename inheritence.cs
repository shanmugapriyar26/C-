using System;
public class Class1
{
    // public void fun1()
    // {
    //     Console.WriteLine("Class 1");
    // }
    public String name;
    public int age;
    public Class1(String name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void details()
    {
        Console.WriteLine(name + " " + age);
    }
}
// public class Class2 : Class1
// {
//     public  void fun2()
//     {
//         Console.WriteLine("Class 2");
//     }
// }
public class HelloWorld
{
    public static void Main()
    {
        Class1 c1 = new Class1("sam", 19);
        c1.details();
        // Class2 c2 = new Class2();
        // c1.fun1();
        // c2.fun2();

    }
}