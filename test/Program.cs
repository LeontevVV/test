using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region red
            Console.ForegroundColor = ConsoleColor.Red;
            int a = 2;
            double b = 2.0;
            string str = "Leontev";
            var variabale = " Vasiliy";
            bool key = true;
            //double result = Math.Sqrt(a * a + b * b);
            Console.WriteLine(variabale + (' ') + (str + variabale).Split(' ')[0]);
            Console.WriteLine((str + variabale).Replace("Vasiliy" + "leontev", "WTF" + "goingon"));
            #endregion
            #region Green
            Console.ForegroundColor = ConsoleColor.Green;
            if (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 6)
            {
                Console.WriteLine("Good Morning");
            }
            else if (DateTime.Now.Hour > 19 && DateTime.Now.Hour < 5)
            {
                Console.WriteLine("Good Night");
            }
            else
            {
                Console.WriteLine("Fuck You");
            }
            #endregion
            #region DarkMagneta
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            var result1 = DateTime.Now.Hour > 11 ? "GodMorning" : "Good Night";
            Console.WriteLine(result1);
            #endregion
            #region Yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (DateTime.Now.Hour)
            {
                case 6: Console.WriteLine("Wake Up"); break;
                case 9: //кейс 9 выполняется в таком случаи как кейс 10
                case 10: Console.WriteLine("Start Work"); break;
                case 13: Console.WriteLine("Branch"); break;
                case 18: Console.WriteLine("Go Home"); break;
                case 23: Console.WriteLine("Mixey XYNTA"); break;
                default: Console.WriteLine(DateTime.Now); break;
            }
            #endregion
            #region Blue
            Console.ForegroundColor = ConsoleColor.Blue;
            while (DateTime.Now.Minute > 58 && DateTime.Now.Minute < 59)
            {
                Console.WriteLine(DateTime.Now);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Fuck");
            }
            #endregion
            #region White
            Console.ForegroundColor = ConsoleColor.White;
            int[] numbers = { 1, 2, 3, 4, 5, 6};
            string[] days = { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday", "Sunday" };
            List<string> str_list = new List<string>();
            days[5] = "Weekend_1";
            days[6] = "Weekend_2";
            for (int i =0; i < days.Length ; i++)
            {
                Console.WriteLine(days[i]);
            }
            str_list.Add("0");
            str_list.Add("");
            str_list.Add("0");
            str_list.AddRange(days);           
            //foreach (var item in str_list.Where(x=>x.StartsWith(""))) 
            foreach (var item in str_list) 
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(str_list.FirstOrDefault(x => x.StartsWith("W"))); выведет первый элемент начинуающийся с символа "W"
            

            #endregion
            #region Gray
            Console.ForegroundColor = ConsoleColor.Gray;

            #endregion

            #region Readline
            Console.ReadLine();
            #endregion
        }
    }   
        
}