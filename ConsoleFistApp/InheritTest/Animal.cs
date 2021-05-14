using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    // Access Modifier : public, protected('상속 클래스' 및 선언 클래스에서만 접근이 가능), private(부모 클래스에 붙이면 상속 불가능해진다)
    class Animal
    {
        protected int Age { get; set; }

        protected Animal() { this.Age = 0; }

        protected void Eat() { Console.WriteLine("냠냠 먹는다"); }
        protected void Sleep() { Console.WriteLine("잠을 잡니다."); }
    }
}
