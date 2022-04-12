
using System;


namespace TH3
{
    class Program
    { 
        static int Main(string[] args)
        { 
        //     // mang 2 chieu
        //   double[,] matrix = new double[10,10];
        //   int count = 0 ;
        //   for(int i=0; i<10;i++){
        //       for(int j=0;j<10;j++){
        //           matrix[i,j]=++count;
        //       }
        //   }
        //   foreach(Double d in matrix)
        //      Console.WriteLine(d);
        // return 0;
        //mag thanh phan
        String[][] softwares = new String[3][];
        softwares[0] = new String[]{
            "Bitdefender","Karparky","NAV"
        };
        softwares[1] = new String[]{
          "IE","Mozilla","Opera","Avant"
        };
        softwares[2] = new String[]{
            "MS word","OpenOffice"
        };
        // for(int i=0;i<softwares.GetLength(0);i++){
        //     for(int j=0;j<softwares[i].GetLength(0);j++){
        //         Console.WriteLine(softwares[i][j]);
        //     }
        // }
        foreach(string[] srr in softwares){
            foreach(String s in srr){
                Console.WriteLine(s);
            }
        }
        return 0;
        }
    }
}
