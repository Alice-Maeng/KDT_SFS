using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Class_3_
{
    public class Animal
    {
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{Name}가 소리를 냅니다 ^0^ ");
        }
    }

    public class Dog : Animal
    {
        public void dv()
        {
            Console.WriteLine("왈왈!!");
        }
    }

    public class Cat : Animal 
    {
        public void cv()
        {
            Console.WriteLine("냐옹냐옹~");
        }

    }

    public class  Bird :Animal
    {
        public void bv()
        {
            Console.WriteLine("짹짹 >_<");
        }
    }

}
