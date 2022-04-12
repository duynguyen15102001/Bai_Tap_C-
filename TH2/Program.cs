
using System;


namespace TH2
{
    class Program
    { 
        static void Main(string[] args)
        {
        //   thuc hanh ve mang
        String[] A = new String[4];
         for(int i=0;i<A.Length;i++){
            Console.Write("A[{0}] = ",i);
            A[i]= Convert.ToInt32(Console.ReadLine());

         }
        // for(int i=0;i<A.Length;i++){
        //     Console.Write("A[{0}] ={1} ",i,A[i]);
        // }
        // Console.WriteLine();
        foreach(string i in A){
                Console.Write(i+"");
        }
        }
    }
}