using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Dog : Animal // Animal 이란 클래스를 상속받겠다.
    {
        //특성
        public string Color { get; set; }

        //기본 생정자 
        public Dog() { this.Age = 0; this.Color = "흰색"; }

        //액션 ( 메서드)
        public void Bark() { Console.WriteLine("멍멍"); }
    }
}
