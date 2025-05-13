using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Class_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region 연습
            // #1. 자식 객체 생성
            Sword sword = new Sword();
            sword.Name = "롱소드";
            sword.Attack();     //부모 메소드 호출
            sword.Sharp();      //자식 고유 메서드 호출

            Console.WriteLine("=========================");

            // #2. Upcasting : 자식 클래스를 부모 클래스 타입으로 참조
            // Why? 
            // ㄴ 다형성을 통해 여러 자식 객체를 부모 타입 하나로 통합하여 유연하고 재사용 가능한 코드로 작성하기 위해
            // 자식 클래스의 고유 기능은 숨겨지고, 부모 클래스의 메서드만 사용 가능 

            // #3. Upcasting 방식 3가지 
            //  ㄴ 1) 묵시적 업캐스팅 (중간 변수 활용)
            Weapon weapon1 = sword;
            weapon1.Attack(); //부모 메서드 호출
            // weapon1.Sharp(); --- 자식 메서드 호출 X !! 

            //  ㄴ 2) 다이렉트 업캐스팅 (바로대입 방식) --- 제일 많이 사용함 
            Weapon weapon2 = new Gun();
            weapon2.Name = "AK-47";
            weapon2.Attack();
            //weapon2.Reload(); --- 자식 메서드 호출 X !!

            //  ㄴ 3) 명시적 업캐스팅 (형변환 기호 사용) - 잘 안씀.
            Weapon weapon3 = (Weapon)new Bow();
            weapon3.Name = "강철 활";
            weapon3.Attack();

            Console.ReadLine();
            Console.WriteLine("=========================");

            // #.4. 추가 내용 적용

            // 검 생성
            Sword sword2 = new Sword(30);
            sword2.Name = "롱소드";
            sword2.Attack();
            Console.WriteLine($"검 공격 데미지: {sword2.Slash(1)}");

            // 업캐스팅 
            Weapon weapon4 = sword2;
            weapon4.Attack();
            //weapon4.Slash(1); --- 역시나 자식클래스 메서드 사용 안됨. 

            //"다운캐스팅"다시 사용 가능하지만 권장하지 않음

            Console.WriteLine($"검 공격 데미지: {((Sword)weapon4).Slash(1)}");
            Console.WriteLine("=========================");
            Console.ReadLine();

            #endregion

            #region 실습
            
            Dog dog = new Dog();
            Animal animal1 = new Dog();
            animal1.Name = "강아지";
            animal1.Speak();
            // animail1.dv();
            ((Dog)animal1).dv();

            Cat cat = new Cat();
            Animal animal2 = new Cat();
            cat.Name = "고양이";
            animal2.Speak();
            // animal2.cv();
            ((Cat)animal2).cv();

            Bird bird = new Bird();
            Animal animal3 = new Bird();
            animal3.Name = "새";
            animal3.Speak();
            //animal3.bv();
            ((Bird)animal3).bv();


            #endregion
        }
    }
}
