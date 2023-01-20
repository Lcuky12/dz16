using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grandmothersLine;
            int onePersonTime = 10;
            int hourLine;
            int minuteLine;

            Console.Write(" Введите кол-во людей ");
            grandmothersLine = Convert.ToInt32(Console.ReadLine());
            hourLine = grandmothersLine * onePersonTime / 60;
            minuteLine = grandmothersLine * onePersonTime % 60;
            Console.WriteLine(" Время ожидания " + (hourLine) + " часов " + (minuteLine) + " минут ");
        }
    }
}
