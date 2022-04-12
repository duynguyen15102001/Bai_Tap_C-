
using System;


namespace Luyentap
{
    public class NV
    { 
       public int MaNV{get; set;}
       public string NameNV{get; set;}
        public override string ToString()
        {
            return MaNV + " , "+NameNV;
        }
    }
}