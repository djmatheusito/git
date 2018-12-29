using System;

namespace Topicos_especiais_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Var

            var x = 10;
            var y = 20.0;
            var z = "Maria";
            

            //switch case

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid Value";
                    break;
            }

            Console.WriteLine(day);
            */


            DateTime d = new DateTime(2001, 8, 15,13,45,58,275);
            Console.WriteLine(d);
            Console.WriteLine("(1) Date: " + d.Date);
            Console.WriteLine("(2) Day: " + d.Day);
            Console.WriteLine(d.ToLongDateString());
        }



    }
}
