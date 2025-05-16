using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Delegate
{
    public class Product
    {
        // #1. 필드&속성
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

        // #2. 생성자 
        public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;

        }

        // #.3 메서드
        /*
         * ToString()은 System.Object 클래스에서 제공하는 기본 메서드
         */
        public override string ToString()
        {
            return $"{Name} / {Price} / {Category}";
        }
    }

}
