
using System;


namespace TH6
{
    public class NV
    { 
       public int MaNV{get; set;}
       public String NameNV{get; set;}
        public override string ToString()
        {
            return MaNV + ","+NameNV;
        }
    }
}