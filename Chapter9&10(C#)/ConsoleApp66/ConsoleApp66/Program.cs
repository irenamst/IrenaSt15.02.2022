using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    internal class Program
    {
        static char[,] lab = 
        {
            {' ',' ',' ','*',' ',' ',' '},
            {'*','*',' ','*',' ','*',' ' },
            {' ',' ',' ',' ',' ',' ',' ' },
            {' ','*','*','*','*','*',' ' },
            {' ',' ',' ',' ',' ',' ','e' }
        };
        static void FindPath(int row,int col)
        {
            if(row < 0 || col < 0 || row >= lab.GetLength(0) || col >= lab.GetLength(1))
            {
                //Иззлиза се от лабиринта
                return;
            }

            //Нека да проверим дали сме намерили изхода
            if(lab[row,col] == 'e')
            {
                Console.WriteLine("Стигна се до изхода.");
            }

            //Стигна се до стеничка на лабилинта.
            if (lab[row, col] !=' ')
            {
                return;
            }

            //Отбелязваме текущата клетка с 's'
            lab[row,col] = 's';
            //Извикайте рекурсия, за да изследвате всички възможни посоки
            FindPath(row, col - 1);//left
            FindPath(row-1, col);//up
            FindPath(row, col + 1);//rigth
            FindPath(row+1, col);//down

            //Маркирайте обратно текущата клетка като свободна
            lab[row, col] = ' ';
        }
        static void Main(string[] args)
        {
            FindPath(0,0);
        }
    }
}
