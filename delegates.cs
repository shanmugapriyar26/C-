using System;
delegate int MathOp(int n);
public class HelloWorld {
  static int number=100;
  public static void Main(string[] args) {
    MathOp c1 = new MathOp(add);
    MathOp c2 = new MathOp(mult);
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(c1(input));
    Console.WriteLine(c2(input));
  }
    public static int add(int n){
        number+=n;
        return number;
    }
    public static int mult(int n){
        number*=n;
        return number;
    }
}
