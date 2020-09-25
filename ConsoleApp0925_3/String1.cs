using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925_3
{
    class String1
    {
        static void Main()
        {

            //while (true)
            //{
            //    try
            //    {
            //        string str1 = "가나다라마바사";
            //        string strEmail = Console.ReadLine();
            //        string str2 = "dbsalszz@naver.com";

            //        Console.WriteLine(str1.Contains('가'));
            //        Console.WriteLine(str2.Contains("라마"));
            //        Console.WriteLine(str1.IndexOf("라마"));

            //        if (!strEmail.Contains("@"))
            //        {
            //            throw new Exception("올바른 이메일 값이 아닙니다.");
            //        }
            //    }
            //    catch (Exception err)
            //    {
            //        Console.WriteLine(err.Message);
            //    }
            //}



            Console.WriteLine("주민등록번호 7자리 입력하세요");
            string idNumber = Console.ReadLine().Trim();

            //7자리가 아닐 떄 처리하기, 밀레니엄 베이비 처리해주기

            string year = idNumber.Substring(0, 2);
            string sex = idNumber.Substring(6);
            string month = idNumber.Substring(2, 2);
            string day = idNumber.Substring(4, 2);
            int gubun = 19;


            if (sex == "1")
            {
                sex = "남자";
               
            }
            else if (sex == "2")
            {
                sex = "늙은 공쥬님";
               
            }

            else if (sex == "3")
            {
                sex = "밀레니엄 보이";
                gubun = 20;
            }
            else if (sex == "4")
            {
                sex = "밀레니엄 공쥬님";
                gubun = 20;
            }

                
            Console.WriteLine($"생년월일 : {gubun}"+ $"{year}년, {month}월, {day}일 출생 \n성별 : {sex}");

            //C:\Users\GDC6\OneDrive\바탕 화면\백업폴더
            string address = @"C:/Users/GDC6/source/repos/ConsoleApp0925/ConsoleApp0925.sln";       //@가 있으면 따옴표 안에 있는 것들을 판단하지 않고 그대로 찍는다
            int location1 = address.LastIndexOf('/');   //41
            int location2 = address.LastIndexOf('.');   //56

            Console.WriteLine($"{location1}, {location2}");
            Console.WriteLine(address.Substring(42));
            Console.WriteLine(address.Substring(57));

            //오늘의 15번째 주문번호
            string today = DateTime.Now.ToString("yyyyMMdd");       //소문자 m은 분을 뜻합니다 D는 요일 d는 일자
            today = DateTime.Now.ToShortDateString().Replace("-", "");
            Console.WriteLine(today);

            string cnt = "15";
            string orderNum = today + cnt.PadLeft(5, '0');
            Console.WriteLine(orderNum);

            



        }



    }

}

