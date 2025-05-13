using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Game
{
    public class Character
    {
        // 필드 & 속성 한 번에 해결!! 
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Maxhp { get; set; }
        public int Damage { get; set; }

        // 생성자 
        public Character() { }

        public Character(string name, int maxhp, int damage) 
        {
            Name = name;
            Maxhp = maxhp;
            Hp = maxhp;
            Damage = damage; 
        }

        // 메소드 
        public void Attack()
        {

        }
    }

    public class Player : Character
    {
        public string Job { get; set; } // wizard & warrior
        public Player(string job, int maxhp, int attack_power) : base (job, maxhp, attack_power)
        {
            Job = job;
        }        
    }

    public class Monster : Character
    {
        public string Type { get; set; }
        public Monster (string type, int maxhp, int attack_power) : base (type, maxhp, attack_power)
        {
            Type = type;
        }

    }

    public class Npc
    {
        public string name { get; set; }
        public Npc() 
        {
            
        }

    }
}
