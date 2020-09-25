using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //Console.WriteLine(DateTime.Now.ToLongDateString());

            //DateTime to = DateTime.Now;     //지금 시간
            //DateTime from = new DateTime(1994, 03, 30);     //다 인트타입이어야만 한다 데이트타입의 생성자는 인트타입이다
            //TimeSpan interval = to - from;
            //Console.WriteLine((to - from).Days);


            //Console.WriteLine(DateTime.Now.AddDays(-3).ToString("yyyy.MM.dd"));     //시간은 빼고 날짜만 보여주고싶을떄     //toshortdaystring도 활용 쌉가능

            //Console.WriteLine(new DateTime(2016, 01, 13).AddDays(2000).AddDays(-7).ToString());

            //DateTime celebration = new DateTime(2020,03,30);

            //Console.WriteLine(celebration.AddDays(1000).ToShortDateString());

            //DateTime test = new DateTime(2020, 09, 26, 13, 0, 0);
            //double rhour = (test - DateTime.Now).TotalHours;
            //Console.WriteLine(rhour);

            //이번 달 1일~말일
            DateTime from = new DateTime(DateTime.Today.Year, 10, 1);
            DateTime to = from.AddMonths(1).AddDays(-1);

            Console.WriteLine($"{from.ToShortDateString()}~{to.ToShortDateString()}");


            //이번 주 일~토
            from = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            to = from.AddDays(6);

            Console.WriteLine($"{from.ToShortDateString()}~{to.ToShortDateString()}");

            DateTime haha = DateTime.Now;
            
            Console.WriteLine(haha.AddYears(100));

            Console.WriteLine("몇 년 후에 100살이 될까?");

            DateTime birth = new DateTime(1994,03,30);
            Console.WriteLine("몇 살인데?");

            Console.WriteLine(haha.AddYears(-(birth.Year)).ToString("yyyy"));
            string x = haha.AddYears(-(birth.Year)).ToShortDateString();
            Console.WriteLine($"{x}년후에");




        }
    }
}
