
using System;


namespace Luyentap
{
    public class QLNV
    { 
      private NV[] data;
      public int Count{get; set;}
      public QLNV(){
          data = null;
          Count = 0;
      }
      public void Add(NV o){
          if(Count == 0){
              data = new NV[Count+1];
              data[Count] = o;
          }
          else{
              NV[] temp = data;
              data = new NV[Count +1];
              for(int i=0;i<Count;++i){
                  data[i]=temp[i];
              }
              data[Count] = o;
          }
          Count++;
      }
    }
}