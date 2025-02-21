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
            // //숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            // int integerNum = 10; // 정수 데이터
            // float floatNum = 3.14f; //단정밀도 실수
            // double doubleNum = 3.14159; //배정밀도 실수

            // System.Console.WriteLine(integerNum);
            // System.Console.WriteLine(floatNum);
            // System.Console.WriteLine(doubleNum);

            // //정수 데이터형식: 소수점이 없는 숫자를 표현
            // int intValue = -100; //4바이트 크기의 정수
            // long longValue = 1234567890L; //8바이트 크기의 정수

            // System.Console.WriteLine(intValue); //출력: -100
            // System.Console.WriteLine(longValue);//출력: 1234567890

            // //부호 있는 정수 : 음수와 양수를 모두 표현가능
            // sbyte signedByte = -50; //1바이트 크기
            // short signedShort = -32000;//2바이트 크기
            // int signedInt = -20000000;//4바이트 크기

            // System.Console.WriteLine(signedByte);
            // System.Console.WriteLine(signedShort);
            // System.Console.WriteLine(signedInt);

            // // 부호없는 정수 데이터 형식
            // byte unsignedByte = 255;//1바이트 크기
            // ushort unsignedUShort = 65000;//2바이트 크기
            // uint unsingedInt = 400000000;//4바이트 크기

            // System.Console.WriteLine(unsignedByte);
            // System.Console.WriteLine(unsignedUShort);
            // System.Console.WriteLine(unsignedByte);

            // //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            // float singPrecision = 3.14f; //단정밀도 실수
            // double doublePrecision = 3.1415926535; //배정밀도 실수 (8바이트)
            // decimal decimalPrecision = 3.141592653545646546546m; //고정밀도 (16바이트)

            // System.Console.WriteLine(singPrecision);
            // System.Console.WriteLine(doublePrecision);
            // System.Console.WriteLine(decimalPrecision);

            // int integerValue = 100; // 기본 정수형 (int)
            // long longValue = 100L; // 정수형 (long)
            // float floatValue = 3.14f; // 실수형 (float)
            // double doubleValue = 3.14; // 기본 실수형 (double)
            // decimal decimalValue = 3.14m; // 고정밀도 실수형 (decimal)

            // Console.WriteLine(integerValue); // 출력: 100
            // Console.WriteLine(longValue); // 출력: 100
            // Console.WriteLine(floatValue); // 출력: 3.14
            // Console.WriteLine(doubleValue); // 출력: 3.14
            // Console.WriteLine(decimalValue); // 출력: 3.14

            // //char형식: 단일 문자를 표현
            // char letter = 'A';
            // char symbol = '#';
            // char number = '9';

            // System.Console.WriteLine(letter);
            // System.Console.WriteLine(symbol);
            // System.Console.WriteLine(number);

            // //string 형식: 여러 문자를 저장
            // string greeting = "Hello World";//문자열 저장
            // string name = "Alice";//이름 저장

            // System.Console.WriteLine(greeting);
            // System.Console.WriteLine(name);
            // System.Console.WriteLine(greeting +" " +name);

            // //bool형식 : 참(true) = 1 거짓 (false) =0

            // bool isRunning = true; // 프로그램 실행 상태
            // bool isFinished = false; //프로그램 종료 상태     

            // System.Console.WriteLine(isRunning); 
            // System.Console.WriteLine(isFinished);

            // const: 변하지 않는 값을 정의
            // const double Pi = 3.14159; // 원주율
            // const int MaxScore = 100; // 최대 점수
            // Console.WriteLine(Pi); // 출력: 3.14159
            // Console.WriteLine(MaxScore); // 출력: 100

            // //닷넷 형식 : 기본 형식의 닷넷표현
            // Int32 number = 123; //int닷넷 형식
            // String text = "Hello"; //string 닷넷 형식
            // Boolean flag = true; //bool의 닷넷 형식

            // System.Console.WriteLine(number);
            // System.Console.WriteLine(text);
            // System.Console.WriteLine(flag);

            //int 래퍼 형식의 메서드 활용
            int number = 1234;
            string numberAsString = number.ToString(); // 정수를 문자열로 변환

            //bool 래퍼형식
            bool flag = true;

            string flagAsString = flag.ToString();  

            System.Console.WriteLine(numberAsString);
            System.Console.WriteLine(flagAsString);

        }

    }

}