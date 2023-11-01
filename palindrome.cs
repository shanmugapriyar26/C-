using System;
class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    String s = "";
    while(n>0){
        s+=n%10;
        n=n/10;
    }
    Console.WriteLine(s);
  }
}

