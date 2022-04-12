// giong include ben C++
using System;

// chua ten folder cua file
namespace LAPTRINHCSDL
{
    class Program
    {
        //   ham thanh nguyen tinh 
        // no cap phat vung nho static
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");
            Console.Write("UED");
            int x=1,y=2;
            Console.WriteLine("Gia tri cua x "+x);
            Console.WriteLine("x = {0}",x);
            Console.WriteLine("x= {0}, y= {1}",x,y);

            //Read(), ReadLine() tra ve kieu String, ReadKey() tra ve gia tri true false
            // int z;
            // Console.WriteLine("x=");
            // x=Console.Read();
            // Console.WriteLine("x={0}",x);
            string n;
            Console.Write("input n =");
            n=Console.ReadLine();
            Console.WriteLine("n= {0}",n);



        }
    }
}