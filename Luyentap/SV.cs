
using System;


namespace Luyentap
{
    public class SV
    { 
        public int MSSV{get; set;}
        public String Name{get; set;}
        public SV(int m,string n){
            MSSV = m;
            Name = n;

        }
        public virtual void show(){
            Console.WriteLine("MSSV = {0} , Name = {1}",MSSV,Name);

        }
        public override string ToString()
        {
            return "MSSV = "+MSSV+" , Name = "+Name;
        }
    }
}