using System;
class HelloWorld
{
    static void Main()
    {
        string str1 = "sam";

        char[] ch = { 'r', 'i', 'y', 'a' };
        string str2 = new string(ch);
        string s = " vakilsearch  ";
        // Console.WriteLine(str1 +" "+ str2);
        // Console.WriteLine(string.Compare(str1,str2));
        // Console.WriteLine(string.Concat(str1,str2));
        // Console.WriteLine(str1.ToUpper()); //tolower, ToUpper&lowerinvariant
        Console.WriteLine(s.TrimEnd());//trim, trimstart
        Console.WriteLine(str1.Contains("m"));

    }
}
