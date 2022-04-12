
using System;


namespace TH6
{
    // lop svcnnt ke thua tu lop SV
    public class SVCNTT : SV
    { 
        public bool LT {get; set;}

        public SVCNTT(int m ,String n,bool lt)
          :base(m,n)
        {
           LT = lt;
        }
        public void showCNTT(){
            Console.WriteLine("{0} - {1} - {2}",MSSV,Name,LT);
        }
        // da hinh thong qua ke thua lop cha
        public override void show(){
            base.show();
            Console.WriteLine("{0}",LT);
        }
        // da hinh boi object
        public override string ToString()
        {
            return "MSSV = " + MSSV + " , Name = " + Name + ", LT = "+LT;
        }
    }
}