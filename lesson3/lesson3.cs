using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class lesson3
    {
        static void Main(string[] args)
        {
            //Задание 1
            int[,] mass = new int[10, 10];
            for (int i=0; i < mass.GetLength(0); i++)
            {
                for (int j=0; j < mass.GetLength(1);j++)
                {
                    if (i == j)
                    {
                        mass[i, j] = 1;
                        Console.Write(mass[i, j]);
                        break;
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine( );
            }
            Console.WriteLine();


            //Задание 2
            string[] name = { "Антон", "Анатолий","Богдан","Владимир","Евгений"};
            long[] numb = {89178921212,89872999537,89276543012,89193556114,89895310000};
            string[,] directory= new string[5, 2];
            for (int i = 0; i < directory.GetLength(0); i++)
            {
                for (int j = 0; j < directory.GetLength(1); j++)
                {
                   
                  if(j==0)
                    {
                        Console.Write(name[i]+"   ");
                    }
                    else Console.Write(numb[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //Задание 3 
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.Write("А теперь учимся читать справа - налево: ");
            for (int i = str.Length - 1; i > -1; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine("\n");



            //Задание 4
            //Здравствуйте, не совсем поняла как выполнять четвертое задание, сделала простейшую карту.
            Console.WriteLine("Ваша карта: ");
            string[,] map = new string[10,10];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if((i+j)%randomaizer()==1||(i+j)/randomaizer()==4)
                    {
                        Console.Write("X ");
                    }
                    else Console.Write("O ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static int randomaizer()
        {
            Random rnd = new Random();
            int n = rnd.Next(3,11);
            return n;
        }
    }
}
