// giong include ben C++
using System;

// chua ten folder cua file
namespace OBJECT010
{
    class Program
    {
        public static void HV(ref int a, ref int b){
            int t=a;
            a=b;
            b=t;
        }
        
        
        public void Add(out int c){
            c=5;
        }
        //   ham thanh nguyen tinh 
        // no cap phat vung nho static
        static void Main(string[] args)
        {
            int m=1,n=2;
            HV(ref m,ref n);
            Console.WriteLine("m= {0},n={1}",m,n);

        }
    }
}