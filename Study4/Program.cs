using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion
{
    class Program
    {
        static void Main(string[] args)
        {

            // //문자열
            // string greeting; // 문자열 변수를 선언
            // greeting = "Hello, World!"; // 변수에 값을 저장
            
            // Console.WriteLine(greeting); // 출력: Hello, World!
            

            // // 변수 선언과 초기화를 한번에 수행
            // int score = 100;
            // double temperature = 36.6; //실수형 변수선언과 초기화
            // string city = "Seoul"; // 문자열 변수 선언과 초기화

            // // 변수 출력
            // System.Console.WriteLine(score); //출력 100
            // System.Console.WriteLine(temperature); // 출력 36.6
            // System.Console.WriteLine(city); // 출력 Seoul

            // //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            // int x = 10, y = 20, z = 30;

            // System.Console.WriteLine(x);
            // System.Console.WriteLine(y);
            // System.Console.WriteLine(z);

            // const double Pi = 3.141592; //상수 Pi 선언 및 초기화
            // const int MaxScore = 100; //정수형 상수 선언
            
            // // 출력 
            // System.Console.WriteLine("Pi : " + Pi);
            // System.Console.WriteLine("Max Score: " + MaxScore);

            //로스트아크 

            int att = 16755, MaxHp = 78103, Critical = 36, specialization = 1017, Subdue = 41, Speed = 611, Patience = 22, skill = 39;
            System.Console.WriteLine("기본 특성");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("공격력      : " + att);
            System.Console.WriteLine("최대 생명력 : " + MaxHp + "\n");
            System.Console.WriteLine("전투 특성");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("치명        : " + Critical);
            System.Console.WriteLine("특화        : " + specialization);
            System.Console.WriteLine("제압        : " + Subdue);
            System.Console.WriteLine("신속        : " + Speed);
            System.Console.WriteLine("인내        : " + Patience);
            System.Console.WriteLine("숙련        : " + skill);
        }

    }

}