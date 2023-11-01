using System;
class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int n1 = 0,n2 =1;
    int temp=0;
    Console.Write(n1+" "+n2+" ");
    for(int i=2;i<n;i++){
        temp=n1+n2;
        Console.Write(temp+" ");
        n1=n2;
        n2=temp;
    }
  }
}

// 0 1 1 2 3 5
