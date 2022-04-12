using System;

namespace TH4 {
    class Program {
        public static void HV(ref int a , ref int b){
            int t=a;
            a=b;
            b=t;
        }
        public static void sort(int[] A){
            for (int i = 0; i < A.Length-1; i++) {
				for (int j = i + 1; j < A.Length; j++) {
					if (A[i] > A[j]) {
						HV(ref A[i],ref A[j]);
					}
				}
			}
        }
        public static void Main(string[] args) {
            Console.Write("nhap phan tu n");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] A = new int[n];

			for (int i = 0; i < A.Length; i++) {
                Console.Write("A[{0}] = ",i);
                 A[i]=Convert.ToInt32(Console.ReadLine());
			}

			sort(A);

			foreach(int i in A) {
				Console.Write(i + " ");
			}
		}

    }
}