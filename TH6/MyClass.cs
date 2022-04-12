
using System;


namespace TH6
{
    public class MyClass : IFILE1,IFILE2
    { 
         public void A(){
           Console.WriteLine("A");
        }
        public void A1(){
           Console.WriteLine("A1");
        }
        public void B1(){
            Console.WriteLine("B1");
        }
        public void A2(){
           Console.WriteLine("A2");
        }
        public void B2(){
            Console.WriteLine("B2");
        }
       public void M(){
           Console.WriteLine("M");
       }

        void IFILE1.A()
        {
             Console.WriteLine("A1");
        }

        void IFILE2.A()
        {
             Console.WriteLine("A2");
        }

      
    }
}