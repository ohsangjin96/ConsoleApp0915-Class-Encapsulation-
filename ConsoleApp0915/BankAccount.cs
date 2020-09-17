using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    public class BankAccount
    {
        //정적멤버는 static 인스턴트멤버는 X (정적은 더이상 안바뀌는것(모든 생산자가 바라보는것) 인스턴트는 계속 바뀔수 있는것)
        private static double interest = 0.2;   //이자율   ---- 멤버변수 (static은 접근 제한자와 타입 사이에 위치한다)
        private string accNum;           //계좌번호 ---- 멤버변수
        private string name;             //예금주명 ---- 멤버변수
        private int balance;         //잔액     ---- 멤버변수
        //인스턴스메서드는 은스턴스 멤버,정적멤버 가능
        //정적메서드는 정적 멤버만 가능
        #region property
        public string AccNum //프로피티(보통 private을 읽어오거나 넣을때 사용)
        {
            get { return accNum; }
            set { accNum = value;} // accNum의 속성을 따라감(여기선 string)
        }
        public string Name 
        {
            get { return name; } 
            set { name = value; } // name의 속성을 따라감(여기선 string)
        }
        public int Balance
        {
            get { return balance; }
            
        }
        #endregion
        #region method
        //출금
        public string OutputMoney(int amount) //변수이름,파라미터 갯수,파라미터 타입으로만 따질수 있다(오버로딩)
        {
            if (balance < amount)
            {
               string errmsg="잔액이 부족합니다";
                return errmsg; //반복문이나 스위치문에서만 break문을 사용한다.
            }
            balance = balance - amount;
            return "";
        }
        //public void OutputMoney(int amount) //void는 반환값이 없어도 된다.
        //{
        //    if (balance < amount)
        //    {
        //        Console.WriteLine("잔액이 부족합니다");
        //        return ; //반복문이나 스위치문에서만 break문을 사용한다.
        //    }
        //    balance = balance - amount;
            
        //}

        //예금
        public void InputMoney(int amount)
        {
            balance = balance + amount + (int)(amount * interest);
        }
        
        //정보 출력
        public void PrintAccInfo()
        {
            Console.WriteLine($"계좌번호:{this.accNum}/예금주명:{this.Name}/잔액:{this.balance}/이자율{BankAccount.interest}");
        }
        //이자율 변경
        public  void SetInterest(double interest)
        {
            BankAccount.interest = interest;//(정적에는 this를 사용하지 못한다, 클래스명을 사용함)
           // balance += 10; //정적인 메서드는 정적인 멤버만 사용가능하다.
        }
        #endregion
        #region ctor

        public BankAccount() //생성자(멤버변수를 초기화)
        {
            balance = 10;
        }

        public BankAccount(string accnum, string accname)
        {
            accNum = accnum; //생성자를 멤버변수한테 주는 방법
            Name = accname; //생성자를 property한테 주는 방법
            balance = 10;   
            // this.accNum=accNum this는 멤버변수를 표시함(이름을 똑같이 줄때 사용)
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args) //static을 안붙이면 인스턴스가 되어버려서 시작점이 사라진다.
        {
            BankAccount acc0 = new BankAccount("111-11111","홍길동");//저장공간생산(인스턴스 생산)
            Console.WriteLine(acc0.Balance);//acc0. 스패너모양은 도구(property)

            BankAccount acc1 = new BankAccount("222-22222","류현진");//저장공간생산
            acc1.Name = "손흥민";
            acc0.InputMoney(500);
            acc0.OutputMoney(100);
            acc0.SetInterest(10);

        
            //if (errmeg.Length > 0)
            //    Console.WriteLine(errmeg);
            //else
            //    Console.WriteLine(acc0.Balance);
            acc0.PrintAccInfo();
            acc1.PrintAccInfo();
        }
    }
}