using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[52, 4];
            int[,] C = new int[52, 4];
            int[] D = new int[52];
            String[] B = new String[] {"спатия","каро","купа","пика"};
            String[] F = new String[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J","Q","K","A" };

            for (int i = 0; i < 52; i++) D[i] = i;

            for(int i=0, br=0; i<49; i=i+4, br++)
            {
                A[i,0] = br; A[i,1] = 0;
                A[i+1,0] = br; A[i+1,1] = 1;
                A[i+2,0] = br; A[i+2,1] = 2;
                A[i+3,0] = br; A[i+3,1] = 3;
            }

            //for (int i = 0; i < 52; i++)
            //{
            //    Console.WriteLine(A[i, 0]+" "+ A[i, 1]);
            //}

            Random randomGenerator=new Random();
            int rand1=randomGenerator.Next(0,52);
            int rand2 = randomGenerator.Next(0, 52);

            for (int j = 0; j < 20; j++)
            {
                rand1 = randomGenerator.Next(0, 52);
                for (int i = 0; i < 20 && rand1 == rand2; i++) { 
                    rand2 = randomGenerator.Next(0, 52); 
                }
                if (rand1 == rand2) { 
                    throw new Exception("генерират се равни числа"); 
                }
                int card = D[rand1];
                D[rand1] = D[rand2];
                D[rand2] = card;
            }
            
            for (int i=0; i < 52; i++)
            {
                C[i, 0] = A[D[i], 0];
                C[i, 1] = A[D[i], 1];
            }

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(F[C[i, 0]]+" "+ B[C[i, 1]]);
            }
            
        }
    }
}
