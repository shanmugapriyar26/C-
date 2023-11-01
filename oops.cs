using System;
public class Class2
{
  public string c = "priya";
}
public class Class1:Class2
{
  public string name;
  public string age;
  private string password;
  public string prop
  {
    set
    {
      password = value;
    }
    get
    {
      return password;
    }
  }
  public Class1 (string name, string age)
  {
    this.name = name;
    this.age = age;
  }
  ~Class1 ()
  {
    Console.WriteLine ("destructor");
  }

}

class MainClass
{
  //static string common = "sam";
  static void Main ()
  {
    // Class1 c1 = new Class1 ("sam", "19");
    // Class1 c2 = new Class1 ("sharmi", "20");
    // Console.WriteLine (common);
    // c.name="sam";
    // c.age="19";
    // Console.WriteLine (c1.name + " " + c1.age);
    // Console.WriteLine (c2.name + " " + c2.age);

    // Class2 p1 = new Class2 ();
    // Console.WriteLine (p1.c);

    // Class1 p2 = new Class1 ("lux","14");
    // Console.WriteLine (p2.c);

    Class1 c3 = new Class1 ("raj", "21");
    // Class1 c4 = new Class1 ();
      c3.prop = "priyapriya";
      Console.WriteLine (c3.name + " " + c3.age);
      Console.WriteLine (c3.prop);
  }
}

