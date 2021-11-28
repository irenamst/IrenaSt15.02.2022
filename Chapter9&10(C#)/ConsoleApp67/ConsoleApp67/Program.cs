using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Program
    {
        static char[,] lab = {
        {' ',' ',' ','*',' ',' ',' ' },
        {'*','*',' ','*',' ','*',' ' },
        {' ',' ',' ',' ',' ',' ',' ' },
        {' ','*','*','*','*','*',' ' },
        {' ',' ',' ',' ',' ',' ','e' }
        };
        static char[] path = new char [lab.GetLength(0)*lab.GetLength(1)];
        static int position=0;
        static void PrintPath(char[] path, int startPosition, int endPosition)
        {
            Console.WriteLine("Намерихме изхода");
            for(int pos=startPosition; pos<endPosition; pos++)
            {
                Console.Write(path[pos]);
            }
            Console.WriteLine();
        }
        static void FindPath(int row,int col,char direction)
        {
            if ((row < 0) || (col < 0) || (row >= lab.GetLength(0)) || (col >=lab.GetLength(1)))
            { 
                //Излезли сме извън лабиринта
                return;
            }

            //Добавяме посока на пътя
            path[position] = direction;
            position++;

            if (lab[row, col] == 'e')
            {
                //Намерили сме изхода
                PrintPath(path, 1, position - 1);
                return;
            }

            

            if (lab[row, col] == ' ')
            {
                //Нека да отбележим откъде сме минали.
                lab[row, col] = 's';

                FindPath(row, col-1, 'L');
                FindPath(row, col + 1, 'R');
                FindPath(row - 1, col, 'U');
                FindPath(row + 1, col, 'D');

                //Отново отбелязваме че клетката е свободна
                lab[row, col] = ' ';
            }
            //изтриване но direction от Path;
            position--;

        }
        static void Main(string[] args)
        {
            FindPath(0, 0, 's');
        }
    }
}
