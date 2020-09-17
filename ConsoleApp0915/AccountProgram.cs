using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp0915 //FullName(다른 네임스페이스에 있는걸 가져올려면 using을 사용해 가져온다.
{
    
    class AccoutManager
    {
       private BankAccount Account;
       public int money;

        public void PrintMenu() //계좌관리프로그램 메뉴
        {
            
            Console.WriteLine("\n------Menu-------");
            Console.WriteLine("1.계좌 개설");
            Console.WriteLine("2.입금");
            Console.WriteLine("3.출금");
            Console.WriteLine("4.잔액 조회");
            Console.WriteLine("5.프로그램 종료");
            
        }
        public void MakeAccount()//1.계좌 개설
        {
                Console.Write("계좌번호:");
                string  accNum = Console.ReadLine();
                Console.Write("예금주명 :");
                string  accName = Console.ReadLine();
                Account = new BankAccount(accNum, accName);

        }
        private bool CheckAccount()//계좌먼저 하는것인지 확인
        {
            if (Account == null)
            {
                Console.WriteLine("계좌개설을 먼저 해주세요");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public void Deposit()//2.입금
        {
            if (CheckAccount() == false) return;

            else
            {
                Console.Write("입금하실 금액은?:");
                money = int.Parse(Console.ReadLine());
                Account.InputMoney(money);
            }
        }
        public void withdraw()//3.출금
        {
            if (CheckAccount() == false) return;

            else
            {
                Console.Write("출금하실 금액은?:");
                money = int.Parse(Console.ReadLine());
                Account.OutputMoney(money);
            }

        }
        public void RemindMoney()//4.잔액조회
        {
            if (CheckAccount() == false) return;

            else
                {
                Console.WriteLine($"당신의 남은 금액은{Account.Balance}입니다");
                }
        }
    }

    class AccountProgram
    {
        static void Main()
        {
            
            AccoutManager manager = new AccoutManager();
            //Console.WriteLine(manager.ToString());//네임스페이스.클래스명
            int choice; //choice를 밖에 두면 메모리가 적게 둔다(안에 들어가면 루프 돌때마다 choice가 계속 할당된다)
            while (true)
            {
                manager.PrintMenu();
                Console.Write("번호를 입력해주세요:");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    
                    case 1:
                        manager.MakeAccount(); break;
                    case 2:
                        manager.Deposit();break;
                    case 3:
                        manager.withdraw();break;
                    case 4:
                        manager.RemindMoney();break;
                    case 5:
                        return; //Environment.Exit(0);은 왠만하면 쓰지 말기
                   
                    default:
                        Console.WriteLine("다시 선택해주세요");break;
                        
                        

                }
               
            }
        }
    }
}
