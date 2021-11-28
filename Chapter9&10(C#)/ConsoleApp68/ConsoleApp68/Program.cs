using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    internal class Program
    {
        static char[,] lab =
        {
            {' ','*',' ',' ',' ',' ','*',' ',' ',' ',' ',' ','*','*',' '},
            {' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ','*','*','*',' ','*',' ',' ',' ',' ',' ','*','*','*','*'},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ','e'}
        };
        static int Rows=lab.GetLength(0);
        static int Cols=lab.GetLength(1);
        static char[] path = new char [Rows * Cols];
        static int position=0;
        static void FindPath(int row,int col,char direction)
        {
            if ((col < 0) || (row < 0) || (col >= Cols) || (row >= Rows) )
            {
                return;
            } 
            path[position] = direction;
            Console.WriteLine("Pos = {0}, PathPosition = {1}, Direction = {2}", position, path[position], direction);
            
            Console.WriteLine("Броят редове = {0}, броят клони ={1}", Rows, Cols);

            Console.WriteLine("Rows = {0}, Cols = {1}", row, col);
            position++;
            
            if (lab[row, col] == ' ')
            {
                lab[row, col] = 's';
                FindPath(row, col - 1, 'L'); // left
                FindPath(row - 1, col, 'U'); // up
                FindPath(row, col + 1, 'R'); // right
                FindPath(row + 1, col, 'D'); // down

                lab[row, col] = ' '; 
                return;
            }
            if (lab[row, col] == 'e')
            {
                PrintPath(path, 1, position - 1);
                return;
            }
            if (lab[row, col] == '*')
            {
                Console.WriteLine("Няма изход.");
                return;
            }
            if (lab[row, col] == 's')
            {
                Console.WriteLine("Спираме.");
                return;
            }
            if ((lab[row, col] != ' ') && (lab[row,row]!= 's') && (lab[row, row] != '*') && (lab[row, row] != 'e'))
            {
                throw new Exception("Има неизвестен символ.");    
            }
            position--;
        }
        static void PrintPath(char[] path, int startPoint, int endPoint)
        {
            Console.WriteLine("Намерихме изхода");
            for (int i = startPoint; i < endPoint; i++)
            {
                Console.Write(path[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            FindPath(0, 0, 'S');
        }
    }
}
