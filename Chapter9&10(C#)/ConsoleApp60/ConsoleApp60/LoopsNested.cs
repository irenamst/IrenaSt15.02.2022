using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class LoopsNested
    {
        //Броя N на елементите в един ред
        static int numberOfLoops;
        //Броя на итерациите K
        static int numberOfIterations;
        //масив с числата от 1 до K
        static int[] loops;
        //Отпечатва N на брой числа от масива на един ред
        static void PrintLoops()
        {
            for(int i=0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ",loops[i]);
            }
            Console.WriteLine();
        }
        //рекурсивен метод, който извиква метода PrintLoops() и отпечата числата на масива от 1 до K в N колони
        //Пример
        /*
        * N=3
        * K=2
        * 1 1 1//loops[0]=1,loops[1]=1,loops[2]=1
        * 1 1 2//loops[0]=1,loops[1]=1,loops[2]=2
        * 1 2 1//loops[0]=1,loops[1]=2,loops[2]=1
        * 1 2 2
        * 2 1 1
        * 2 1 2
        * 2 2 1
        * 2 2 2
        */
        static void NestedLoops(int currentLoop)
        {
            // докато currentLoop не стане N, не се отпечатват елементите на редицата и този изход се пропуска
            if(currentLoop == numberOfLoops)
            {
                //в PrintLoops() се отпечатва получения масив loops
                PrintLoops();
               return;
            }

            //Присвояваме следващото число на поредната позиция и отпечатваме k реда с по N елемента
            for(int counter = 1; counter <= numberOfIterations; counter++)
            {
               
                loops[currentLoop] = counter;
                int current = currentLoop + 1;
                NestedLoops(current);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("N=");
            numberOfLoops=int.Parse(Console.ReadLine());
            Console.Write("K=");
            numberOfIterations=int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }
    }
}
