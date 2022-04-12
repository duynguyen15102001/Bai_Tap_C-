
using System;


namespace TH4
{
    public class SV
    { 
       private int _MSSV;
       private String _Name;

       //property
       public String Name{
         get {return _Name;}
         set {_Name = value;}
       }
       //getter
       public int MSSV(){
         return _MSSV;
       }
       //setter
       public void MSSV(int new_value){
         _MSSV = new_value;
       }
       public SV(){
          _MSSV=1;
          _Name="NVA";
       }
       public SV(int _MSSV,String n){
         this._MSSV=_MSSV;
          _Name = n;
       }
       public SV(SV s){
         _MSSV = s._MSSV;
         _Name = s._Name;
       }
       public void show(){
         Console.WriteLine("MSSV = {0} , Name = {1}",_MSSV,_Name);
       }
    }
}