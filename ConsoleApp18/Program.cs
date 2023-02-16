using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    struct MyDate
    {
        public DateTime date;
        public MyDate(int d, int m, int y)
        {
            date = new DateTime(y, m, d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cou;
            MyDate d = new MyDate(1, 1, 2000);
            Console.WriteLine(d.date.ToString());


            int day = d.date.Day, month = d.date.Month;

            var current = DateTime.Today;
            int year = current.Month > month || current.Month == month && current.Day > day
                   ? current.Year + 1 : current.Year;

            var days = (new DateTime(year, month, day) - current).TotalDays;
            Console.WriteLine(days);

        }
    }
}
