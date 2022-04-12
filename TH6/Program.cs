
using System;


namespace TH6
{
    class Program
    { 
        static void Main(string[] args)
        {
            // SV s1 = new SV
            // {
            //      MSSV = 1,
            //      Name = "NVA"
            // };
            // s1.show();
            // SVCNTT s2 = new SVCNTT{
            //     MSSV = 2,
            //     Name = "NVB",
            //     LT = false
            // // };
            // SVCNTT s2 = new SVCNTT(2 , "NVB",true);
            // Console.WriteLine(s2.ToString());

            // SV s1 = new SV(1, "A");
            // Console.WriteLine(s1.ToString());
            // s2.showCNTT();
            // s2.show();
            // QLNV db = new QLNV();
            // NV o1 =new NV{MaNV =1,NameNV="NVA"};
            // NV o2 =new NV{MaNV =2,NameNV="NVB"};
            // db.Add(o1);
            // db.Add(o2);
            // // Console.WriteLine(db.IndexOf(o2));
            // NV o3 = new NV{MaNV = 3,NameNV = "NVC"};
            // Console.WriteLine(db.IndexOf(o3));
            // db.Add(o3);
            // // db.RemoveAt(1);
            // // db.Remove(o2);
            // // Console.WriteLine(db.ToString());
            // NV o4 = new NV{MaNV = 3 , NameNV = "AAA"};
            // db.Update(o4);
            // Console.WriteLine(db.ToString());

             MyClass m = new MyClass();
            //  m.A1(); m.B1();
            //  m.A2(); m.B2();
              m.M();
           
             
             IFILE1 f1 = (IFILE1)m;
            //  f1.A1();
            //  f1.B1();
            f1.A();
            
             IFILE2 f2 = (IFILE2)m;
            //  f2.A2();
            //  f2.B2();
            f2.A();
            
        }
    }
}