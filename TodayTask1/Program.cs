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
            Console.Clear();
            //로딩바 시작화면
            //게임스토리1
            //비주얼 노벨 만들어보기
            System.Console.WriteLine("***  Press Enter to Begin  ***");
            System.Console.ReadLine();
            Console.Clear();
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\n{name}님 환영합니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"조용한 이 공간에서 당신은 깨어났습니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"이곳은 아직 무(無)와도 같은 세계. 빛과 그림자가 얽혀 만들어진 흑백의 공간입니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"그러나, {name}님이 존재하는 순간부터 이곳은 변하기 시작합니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"당신의 발걸음이 닿는 곳마다, 손길이 머무는 곳마다, 세계는 조용히 반응할 것입니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"아직은 한 가지 색조만이 존재하는 단조로운 세계지만,");
            Thread.Sleep(1000);
            Console.WriteLine($"당신이 이곳에서 겪는 경험과 선택이 새로운 빛을 불어넣을 것입니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"당신이 걷는 길 위에 색이 스며들고,");
            Thread.Sleep(1000);
            Console.WriteLine($"당신이 만나는 존재들과 함께 이 공간은 더욱 생명력을 띠게 될 것입니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"하지만, 모든 변화는 노력과 탐험으로부터 시작됩니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"스스로 성장하고, 선택하고, 탐험하세요.");
            Thread.Sleep(1000);
            Console.WriteLine($"어쩌면, 아주 먼 미래에는 이곳이 무한한 색채와 이야기가 넘치는 세계가 될지도 모릅니다.");
            Thread.Sleep(1000);
            Console.WriteLine($"당신과 함께, 더 넓고 다채로운 세계를 만들어 가고 싶습니다.");
            Thread.Sleep(1000);
            Console.WriteLine("\n> 첫걸음을 내디디겠습니까? (Press Enter to continue)");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine($"세계가 서서히 반응하기 시작한다...");

            Console.WriteLine("\n========================================");
            Console.WriteLine("                                        \n");
            Console.WriteLine("        WELCOME TO LIBRESQUE        ");
            Console.WriteLine("                                        \n"); 
            Console.WriteLine("========================================\n");

        }

    }

}