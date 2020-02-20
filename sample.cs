using System;
namespace sample
 {
       public class sample{
                         public static void Main(){
                      int x;
            string ename;
            Console.WriteLine("enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("enter ur age");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("congrats Mr/Ms {0} on your{1}  birthday", ename,x);
            Console.ReadKey();
}
 }
}