
using System;


namespace TH6
{
    public class QLNV
    { 
        private NV[] data;
        public int Count{get; set;}
        public QLNV(){
            data = null;
            Count = 0;
        }
        // Them 1 doi tuong NV cuoi mang
        public void Add(NV o){
           if(Count == 0){
               data = new NV[Count+1];
            //   them doi tuong o vao mang
               data[Count] = o;
           }
           else{
               NV[] temp = data;
               data = new NV[Count + 1];
               for(int i=0;i < Count ; ++i){
                   data[i] = temp[i];
               }
               data[Count] = o;
           }
           Count++;
        }
        //Them 1 doi tuong NV vao vi tri index
        public void insert(NV o , int index){

        }
        public override string ToString()
        {
            string s = "";

            foreach(NV i in data){
                s+=i.ToString() + "\n";
            }
            return s;
            
        }
        // Neu tim thay phan tu trung trong mang -> tra ve vi tri phan tu trung
        // Neu khong tim thay -> tra ve -1
        public int IndexOf(NV o){
            int index = -1;
            for(int i=0;i < Count;i++){
                if(data[i]==o){
                    index = i;
                    break;
                }
            }
            return index;
        }
    
        public void RemoveAt(int index){
            if(Count > 0 ){
                if(Count ==1){
                    data = null;
                }
                else{
                    NV[] temp = data;
                    data = new NV[Count-1];
                    for(int i=0;i < Count;i++){
                        if(i < index){
                            data[i]= temp[i];
                        }
                        if(i>index){
                           data[i-1] = temp[i];
                        }
                    }
                }

            }
            Count--;
        }
         public void Remove(NV o){
             if(IndexOf(o) >= 0){
                 RemoveAt(IndexOf(o));
             }
        }
        //Tim xem co phan tu nao trong mang co thuoc tinh MaNV = o.MaNV
        // -> do la doi tuong can edit
        public async void Update(NV o){
           for(int i=0;i < Count;i++){
               if(data[i].MaNV == o.MaNV){
                   data[i].NameNV = o.NameNV;
               }
           }
        }
    }
}