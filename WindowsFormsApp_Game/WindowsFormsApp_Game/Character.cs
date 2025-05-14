using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp_Game
{
    public class Character
    {
        // 필드 & 속성 한 번에 해결!! 
        public string Job { get; set; }
        public int Hp { get; set; }
        public int Maxhp { get; set; }
        public int Damage { get; set; }

        // 생성자 
        public Character() { }
        public Character(string job) 
        {
            this.Job = job;
        }

        // 메소드 
        public void Attack(Character target)
        {
            while (target.Hp > 0)
            {
                Console.WriteLine($"{Job}가 {target.Job}을 공격합니다.");
                target.Hp -= this.Damage;

                if (target.Hp < 0)
                    target.Hp = 0;

                Console.WriteLine($"{target.Job}의 남은 체력: {target.Hp}");

                if (target.Hp == 0)
                {
                    Console.WriteLine($"{target.Job}이(가) 죽었습니다!");
                }
            }

        }
    }

    public class Player : Character
    {
        public Player() { }
        public Player(string name) : base (name)
        {
            if (name == "wizard")
            {
                Maxhp = 100;
                Damage = 20;
            }
            else if (name == "warrior")
            {
                Maxhp = 100;
                Damage = 30;
            }

            Console.WriteLine($"{Job}를(을) 선택하셨습니다.");
            Console.WriteLine($"체력은 {Maxhp}, 공격력은 {Damage} 입니다.");
        }        
    }

    public class Monster : Character
    {

        public Monster() { }
        public Monster(string type) : base(type)
        {
            if (type == "slime")
            {
                Maxhp = 50;
                Damage = 5;
            }
            else if (type == "orc")
            {
                Maxhp = 100;
                Damage = 10;
            }

            Hp = Maxhp;
            Console.WriteLine($"체력은 {Maxhp}, 공격력은 {Damage} 입니다.");
        }

    }

    /*
    public class Npc 
    {
        public string Name { get; set; }
        public Npc(string name) 
        {
            Name = name; 
        }
 
    }
    */
}
