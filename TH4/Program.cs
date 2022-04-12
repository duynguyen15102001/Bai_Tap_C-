
using System;


namespace TH4
{
    class Program
    { 
        static void Main(string[] args)
        {
           SV s1 = new SV();
           SV s2 = new SV(2,"NVB");
           SV s3 = new SV(s2);
       
           s1.MSSV(s3.MSSV());
           s1.Name= s3.Name;
           s1.show();
        //    s2.show();
        //    s3.show();
        }
    }
}